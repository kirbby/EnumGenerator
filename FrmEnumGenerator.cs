using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EnumGenerator
{
    public partial class FrmEnumGenerator : Form
    {
        private SqlConnection _Connection;
        private List<string> _Columns;

        public FrmEnumGenerator()
        {
            InitializeComponent();

            InitCboServer();
        }

        private void InitCboServer()
        {
            var servers = new List<string>();
            var instances = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();

            foreach (System.Data.DataRow instance in instances.Rows)
            {
                servers.Add(instance[instances.Columns["ServerName"]].ToString() + @"\" + instance[instances.Columns["InstanceName"]].ToString());
            }

            CboServers.DataSource = servers;
        }

        private void LoadCboDatabase()
        {
            CboDatabase.DataSource = GetListOnSelect("EXEC sp_databases", "DATABASE_NAME");          
        }

        private void LoadCboTable()
        {
            CboTable.DataSource = GetListOnSelect("SELECT [TABLE_NAME] FROM [" + CboDatabase.SelectedValue + "].INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", "TABLE_NAME");
        }

        private void LoadColumnCbos()
        {
            _Columns = GetListOnSelect("SELECT * FROM [" + CboDatabase.SelectedValue + "].INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + CboTable.SelectedValue + "'", "COLUMN_NAME");

            var columnsKey = new List<string>();
            var columnsValue = new List<string>();

            columnsKey.AddRange(_Columns);
            columnsValue.AddRange(_Columns);

            CboKey.DataSource = columnsKey;
            CboValue.DataSource = columnsValue;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (CboKey.SelectedValue == CboValue.SelectedValue)
            {
                MessageBox.Show("Please choose different columns for Key and Value!");
                return;
            }

            if (string.IsNullOrEmpty((string)CboDatabase.SelectedValue) || string.IsNullOrEmpty((string)CboTable.SelectedValue) ||
                string.IsNullOrEmpty((string)CboKey.SelectedValue) || string.IsNullOrEmpty((string)CboValue.SelectedValue))
            {
                MessageBox.Show("Please select something in every dropdown!");
                return;
            }

            if (!IsDatatypesCorrect())
            {
                MessageBox.Show("The datatypes of the selected columns are not correct! ID = int; Value = string");
                return;
            }

            TxtOutput.Text = "";
            WriteOutput(
                GetDictOnSelect("Select [" + CboValue.SelectedValue + "], [" + CboKey.SelectedValue + "] from [" + CboTable.SelectedValue + "]",
                (string)CboKey.SelectedValue, (string)CboValue.SelectedValue)
                );
        }

        private bool IsDatatypesCorrect()
        {
            var keyType = GetDatatype((string)CboKey.SelectedValue);
            var valueType = GetDatatype((string)CboValue.SelectedValue);

            if (keyType != "int" || !(valueType == "varchar" || valueType == "nchar" || valueType == "ntext" || valueType == "char" || valueType == "nvarchar" || valueType == "text"))
            {
                return false;
            }

            return true;
        }

        private void WriteOutput(Dictionary<int, string> dictionary)
        {
            TxtOutput.Text = "enum Permissions" + Environment.NewLine +
                  "{" + Environment.NewLine;

            foreach(var item in dictionary)
            {
                TxtOutput.Text += "\t" + Regex.Replace(item.Value, "[.,@;\\/:*?\"<>|&']", "_") + " = " + item.Key + "," + Environment.NewLine;
            }

            TxtOutput.Text += "}";

            TxtOutput.Focus();

            Clipboard.SetText(TxtOutput.Text);
        }

        private void CboDatabase_ValueChanged(object sender, EventArgs e)
        {
            _Connection = new SqlConnection(@"Server=" + CboServers.SelectedValue + "; Integrated Security=true; Database = " + CboDatabase.SelectedValue + ";");

            LoadCboTable();
        }
        
        private void CboTable_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadColumnCbos();
        }

        private List<string> GetListOnSelect(string select, string fieldName)
        {
            try
            {
                _Connection.Open();

                var command = new SqlCommand(select, _Connection);
                var databases = new List<string>();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = reader[fieldName];

                        if (!Convert.IsDBNull(item))
                        {
                            databases.Add((string)item);
                        }
                    }
                }

                _Connection.Close();

                return databases;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data! " + Environment.NewLine + ex.Message);
                _Connection.Close();

                return null;
            }
        }

        private Dictionary<int, string> GetDictOnSelect(string select, string fieldNameKey, string fieldNameValue)
        {
            try
            {
                _Connection.Open();

                var command = new SqlCommand(select, _Connection);
                var enumDict = new Dictionary<int, string>();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var key = reader[fieldNameKey];
                        var value = reader[fieldNameValue];

                        if (!Convert.IsDBNull(key) && !Convert.IsDBNull(value))
                        {
                            enumDict.Add((int)key, (string)value);
                        }
                    }
                }

                _Connection.Close();

                return enumDict;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data! " + Environment.NewLine + ex.Message);
                _Connection.Close();

                return null;
            }
        }

        private string GetDatatype(string fieldName)
        {
            try
            {
                _Connection.Open();

                var command = new SqlCommand("SELECT DATA_TYPE FROM [" + CboDatabase.SelectedValue + "].INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" 
                    + CboTable.SelectedValue + "' AND COLUMN_NAME = '" + fieldName + "'", _Connection);
                var datatype = "";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var datatypeTemp = reader["DATA_TYPE"];

                        if (!Convert.IsDBNull(datatypeTemp))
                        {
                            datatype = (string)datatypeTemp;
                        }
                    }
                }

                _Connection.Close();

                return datatype;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data! " + Environment.NewLine + ex.Message);
                _Connection.Close();

                return null;
            }
        }

        private void CboServers_SelectedValueChanged(object sender, EventArgs e)
        {
            _Connection = new SqlConnection(@"Server=" + CboServers.SelectedValue + "; Integrated Security=true;");

            LoadCboDatabase();
        }
    }
}
