namespace EnumGenerator
{
    partial class FrmEnumGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtOutput = new System.Windows.Forms.RichTextBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblDatabase = new System.Windows.Forms.Label();
            this.LblTable = new System.Windows.Forms.Label();
            this.LblKey = new System.Windows.Forms.Label();
            this.LblValue = new System.Windows.Forms.Label();
            this.CboDatabase = new System.Windows.Forms.ComboBox();
            this.CboTable = new System.Windows.Forms.ComboBox();
            this.CboKey = new System.Windows.Forms.ComboBox();
            this.CboValue = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CboServers = new System.Windows.Forms.ComboBox();
            this.LblServer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtOutput
            // 
            this.TxtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutput.Location = new System.Drawing.Point(12, 104);
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.ReadOnly = true;
            this.TxtOutput.Size = new System.Drawing.Size(844, 459);
            this.TxtOutput.TabIndex = 0;
            this.TxtOutput.Text = "";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(12, 75);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 1;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LblDatabase
            // 
            this.LblDatabase.AutoSize = true;
            this.LblDatabase.Location = new System.Drawing.Point(171, 0);
            this.LblDatabase.Name = "LblDatabase";
            this.LblDatabase.Size = new System.Drawing.Size(84, 13);
            this.LblDatabase.TabIndex = 6;
            this.LblDatabase.Text = "Database Name";
            // 
            // LblTable
            // 
            this.LblTable.AutoSize = true;
            this.LblTable.Location = new System.Drawing.Point(339, 0);
            this.LblTable.Name = "LblTable";
            this.LblTable.Size = new System.Drawing.Size(65, 13);
            this.LblTable.TabIndex = 7;
            this.LblTable.Text = "Table Name";
            // 
            // LblKey
            // 
            this.LblKey.AutoSize = true;
            this.LblKey.Location = new System.Drawing.Point(507, 0);
            this.LblKey.Name = "LblKey";
            this.LblKey.Size = new System.Drawing.Size(56, 13);
            this.LblKey.TabIndex = 8;
            this.LblKey.Text = "ID Column";
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Location = new System.Drawing.Point(675, 0);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(98, 13);
            this.LblValue.TabIndex = 9;
            this.LblValue.Text = "Description Column";
            // 
            // CboDatabase
            // 
            this.CboDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboDatabase.FormattingEnabled = true;
            this.CboDatabase.Location = new System.Drawing.Point(171, 23);
            this.CboDatabase.Name = "CboDatabase";
            this.CboDatabase.Size = new System.Drawing.Size(162, 21);
            this.CboDatabase.TabIndex = 10;
            this.CboDatabase.SelectedValueChanged += new System.EventHandler(this.CboDatabase_ValueChanged);
            // 
            // CboTable
            // 
            this.CboTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboTable.FormattingEnabled = true;
            this.CboTable.Location = new System.Drawing.Point(339, 23);
            this.CboTable.Name = "CboTable";
            this.CboTable.Size = new System.Drawing.Size(162, 21);
            this.CboTable.TabIndex = 11;
            this.CboTable.SelectedValueChanged += new System.EventHandler(this.CboTable_SelectedValueChanged);
            // 
            // CboKey
            // 
            this.CboKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboKey.FormattingEnabled = true;
            this.CboKey.Location = new System.Drawing.Point(507, 23);
            this.CboKey.Name = "CboKey";
            this.CboKey.Size = new System.Drawing.Size(162, 21);
            this.CboKey.TabIndex = 12;
            // 
            // CboValue
            // 
            this.CboValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboValue.FormattingEnabled = true;
            this.CboValue.Location = new System.Drawing.Point(675, 23);
            this.CboValue.Name = "CboValue";
            this.CboValue.Size = new System.Drawing.Size(166, 21);
            this.CboValue.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.CboServers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CboValue, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblValue, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.CboKey, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblKey, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CboTable, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CboDatabase, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDatabase, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblServer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 57);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // CboServers
            // 
            this.CboServers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboServers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboServers.FormattingEnabled = true;
            this.CboServers.Location = new System.Drawing.Point(3, 23);
            this.CboServers.Name = "CboServers";
            this.CboServers.Size = new System.Drawing.Size(162, 21);
            this.CboServers.TabIndex = 14;
            this.CboServers.SelectedValueChanged += new System.EventHandler(this.CboServers_SelectedValueChanged);
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Location = new System.Drawing.Point(3, 0);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(84, 13);
            this.LblServer.TabIndex = 15;
            this.LblServer.Text = "Server\\Instance";
            // 
            // FrmEnumGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 575);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmEnumGenerator";
            this.ShowIcon = false;
            this.Text = "EnumGenerator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtOutput;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label LblDatabase;
        private System.Windows.Forms.Label LblTable;
        private System.Windows.Forms.Label LblKey;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.ComboBox CboDatabase;
        private System.Windows.Forms.ComboBox CboTable;
        private System.Windows.Forms.ComboBox CboKey;
        private System.Windows.Forms.ComboBox CboValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CboServers;
        private System.Windows.Forms.Label LblServer;
    }
}

