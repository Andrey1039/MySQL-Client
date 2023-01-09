
namespace Database
{
    partial class ProgramWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramWindow));
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.DbBox = new System.Windows.Forms.ComboBox();
            this.HidePassBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.RecordTable = new System.Windows.Forms.DataGridView();
            this.ListTableBox = new System.Windows.Forms.ComboBox();
            this.DelRecordBtn = new System.Windows.Forms.Button();
            this.UpdateDbBtn = new System.Windows.Forms.Button();
            this.AddRecordBtn = new System.Windows.Forms.Button();
            this.ChangeRecBtn = new System.Windows.Forms.Button();
            this.WorkWindow = new System.Windows.Forms.Panel();
            this.SaveExcelBtn = new System.Windows.Forms.Button();
            this.LoadExcelBtn = new System.Windows.Forms.Button();
            this.WorkControls = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.hints = new System.Windows.Forms.ToolTip(this.components);
            this.LoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable)).BeginInit();
            this.WorkWindow.SuspendLayout();
            this.WorkControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginBox.Controls.Add(this.DbBox);
            this.LoginBox.Controls.Add(this.HidePassBox);
            this.LoginBox.Controls.Add(this.label2);
            this.LoginBox.Controls.Add(this.LoginBtn);
            this.LoginBox.Controls.Add(this.passLabel);
            this.LoginBox.Controls.Add(this.loginLabel);
            this.LoginBox.Controls.Add(this.PassTB);
            this.LoginBox.Controls.Add(this.LoginTB);
            this.LoginBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginBox.Location = new System.Drawing.Point(279, 125);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(338, 335);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Вход";
            // 
            // DbBox
            // 
            this.DbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DbBox.FormattingEnabled = true;
            this.DbBox.Location = new System.Drawing.Point(60, 216);
            this.DbBox.Name = "DbBox";
            this.DbBox.Size = new System.Drawing.Size(231, 28);
            this.DbBox.TabIndex = 8;
            this.DbBox.SelectedIndexChanged += new System.EventHandler(this.DbBox_SelectedIndexChanged);
            // 
            // HidePassBox
            // 
            this.HidePassBox.AutoSize = true;
            this.HidePassBox.Location = new System.Drawing.Point(145, 160);
            this.HidePassBox.Name = "HidePassBox";
            this.HidePassBox.Size = new System.Drawing.Size(150, 24);
            this.HidePassBox.TabIndex = 7;
            this.HidePassBox.Text = "Показать пароль";
            this.HidePassBox.UseVisualStyleBackColor = true;
            this.HidePassBox.CheckedChanged += new System.EventHandler(this.HidePassBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "База данных";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(99, 271);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(158, 42);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(32, 104);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(62, 20);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(32, 38);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 20);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(60, 127);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(231, 27);
            this.PassTB.TabIndex = 1;
            this.PassTB.UseSystemPasswordChar = true;
            this.PassTB.TextChanged += new System.EventHandler(this.PassTB_TextChanged);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(60, 61);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(231, 27);
            this.LoginTB.TabIndex = 0;
            this.LoginTB.TextChanged += new System.EventHandler(this.LoginTB_TextChanged);
            // 
            // RecordTable
            // 
            this.RecordTable.AllowUserToAddRows = false;
            this.RecordTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RecordTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RecordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordTable.Location = new System.Drawing.Point(18, 71);
            this.RecordTable.Name = "RecordTable";
            this.RecordTable.ReadOnly = true;
            this.RecordTable.RowHeadersWidth = 51;
            this.RecordTable.RowTemplate.Height = 29;
            this.RecordTable.Size = new System.Drawing.Size(883, 493);
            this.RecordTable.TabIndex = 1;
            this.RecordTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.RecordTable_DataError);
            // 
            // ListTableBox
            // 
            this.ListTableBox.FormattingEnabled = true;
            this.ListTableBox.Location = new System.Drawing.Point(80, 11);
            this.ListTableBox.Name = "ListTableBox";
            this.ListTableBox.Size = new System.Drawing.Size(151, 28);
            this.ListTableBox.TabIndex = 3;
            this.ListTableBox.SelectedIndexChanged += new System.EventHandler(this.ListTableBox_SelectedIndexChanged);
            // 
            // DelRecordBtn
            // 
            this.DelRecordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelRecordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DelRecordBtn.Image = ((System.Drawing.Image)(resources.GetObject("DelRecordBtn.Image")));
            this.DelRecordBtn.Location = new System.Drawing.Point(569, 0);
            this.DelRecordBtn.Name = "DelRecordBtn";
            this.DelRecordBtn.Size = new System.Drawing.Size(53, 53);
            this.DelRecordBtn.TabIndex = 4;
            this.hints.SetToolTip(this.DelRecordBtn, "Удалить записи");
            this.DelRecordBtn.UseVisualStyleBackColor = true;
            this.DelRecordBtn.Click += new System.EventHandler(this.DelRecBtn_Click);
            // 
            // UpdateDbBtn
            // 
            this.UpdateDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateDbBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpdateDbBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateDbBtn.Image")));
            this.UpdateDbBtn.Location = new System.Drawing.Point(746, 0);
            this.UpdateDbBtn.Name = "UpdateDbBtn";
            this.UpdateDbBtn.Size = new System.Drawing.Size(53, 53);
            this.UpdateDbBtn.TabIndex = 5;
            this.hints.SetToolTip(this.UpdateDbBtn, "Обновить данные");
            this.UpdateDbBtn.UseVisualStyleBackColor = true;
            this.UpdateDbBtn.Click += new System.EventHandler(this.UpdateDbBtn_Click);
            // 
            // AddRecordBtn
            // 
            this.AddRecordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRecordBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddRecordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddRecordBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddRecordBtn.Image")));
            this.AddRecordBtn.Location = new System.Drawing.Point(628, 0);
            this.AddRecordBtn.Name = "AddRecordBtn";
            this.AddRecordBtn.Size = new System.Drawing.Size(53, 53);
            this.AddRecordBtn.TabIndex = 6;
            this.AddRecordBtn.Tag = "Добавить запись";
            this.hints.SetToolTip(this.AddRecordBtn, "Добавить записи");
            this.AddRecordBtn.UseVisualStyleBackColor = false;
            this.AddRecordBtn.Click += new System.EventHandler(this.AddRecordBtn_Click);
            // 
            // ChangeRecBtn
            // 
            this.ChangeRecBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeRecBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChangeRecBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChangeRecBtn.Image = ((System.Drawing.Image)(resources.GetObject("ChangeRecBtn.Image")));
            this.ChangeRecBtn.Location = new System.Drawing.Point(687, 0);
            this.ChangeRecBtn.Name = "ChangeRecBtn";
            this.ChangeRecBtn.Size = new System.Drawing.Size(53, 53);
            this.ChangeRecBtn.TabIndex = 7;
            this.ChangeRecBtn.Tag = "Редактировать запись";
            this.hints.SetToolTip(this.ChangeRecBtn, "Редактировать записи");
            this.ChangeRecBtn.UseVisualStyleBackColor = false;
            this.ChangeRecBtn.Click += new System.EventHandler(this.ChangeRecBtn_Click);
            // 
            // WorkWindow
            // 
            this.WorkWindow.BackgroundImage = global::Database.Properties.Resources.Background;
            this.WorkWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorkWindow.Controls.Add(this.RecordTable);
            this.WorkWindow.Controls.Add(this.SaveExcelBtn);
            this.WorkWindow.Controls.Add(this.LoadExcelBtn);
            this.WorkWindow.Controls.Add(this.WorkControls);
            this.WorkWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkWindow.Location = new System.Drawing.Point(0, 0);
            this.WorkWindow.Name = "WorkWindow";
            this.WorkWindow.Size = new System.Drawing.Size(918, 576);
            this.WorkWindow.TabIndex = 8;
            // 
            // SaveExcelBtn
            // 
            this.SaveExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveExcelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveExcelBtn.BackgroundImage")));
            this.SaveExcelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveExcelBtn.Enabled = false;
            this.SaveExcelBtn.Location = new System.Drawing.Point(491, 12);
            this.SaveExcelBtn.Name = "SaveExcelBtn";
            this.SaveExcelBtn.Size = new System.Drawing.Size(53, 53);
            this.SaveExcelBtn.TabIndex = 10;
            this.hints.SetToolTip(this.SaveExcelBtn, "Выгрузить таблицу в Excel");
            this.SaveExcelBtn.UseVisualStyleBackColor = true;
            this.SaveExcelBtn.Click += new System.EventHandler(this.SaveExcelBtn_Click);
            // 
            // LoadExcelBtn
            // 
            this.LoadExcelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadExcelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadExcelBtn.BackgroundImage")));
            this.LoadExcelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadExcelBtn.Enabled = false;
            this.LoadExcelBtn.Location = new System.Drawing.Point(427, 12);
            this.LoadExcelBtn.Name = "LoadExcelBtn";
            this.LoadExcelBtn.Size = new System.Drawing.Size(53, 53);
            this.LoadExcelBtn.TabIndex = 11;
            this.hints.SetToolTip(this.LoadExcelBtn, "Загрузить таблицу из Excel");
            this.LoadExcelBtn.UseVisualStyleBackColor = true;
            this.LoadExcelBtn.Click += new System.EventHandler(this.LoadExcelBtn_Click);
            // 
            // WorkControls
            // 
            this.WorkControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkControls.BackColor = System.Drawing.Color.Transparent;
            this.WorkControls.Controls.Add(this.ChangeRecBtn);
            this.WorkControls.Controls.Add(this.label1);
            this.WorkControls.Controls.Add(this.DelRecordBtn);
            this.WorkControls.Controls.Add(this.UpdateDbBtn);
            this.WorkControls.Controls.Add(this.AddRecordBtn);
            this.WorkControls.Controls.Add(this.logoutBtn);
            this.WorkControls.Controls.Add(this.ListTableBox);
            this.WorkControls.Location = new System.Drawing.Point(18, 12);
            this.WorkControls.Name = "WorkControls";
            this.WorkControls.Size = new System.Drawing.Size(883, 53);
            this.WorkControls.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Таблица:";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(830, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(53, 53);
            this.logoutBtn.TabIndex = 8;
            this.hints.SetToolTip(this.logoutBtn, "Выйти из учетной записи");
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ProgramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 576);
            this.Controls.Add(this.WorkWindow);
            this.Controls.Add(this.LoginBox);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(936, 623);
            this.Name = "ProgramWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных MySQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgramWindow_FormClosing);
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable)).EndInit();
            this.WorkWindow.ResumeLayout(false);
            this.WorkControls.ResumeLayout(false);
            this.WorkControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.DataGridView RecordTable;
        private System.Windows.Forms.ComboBox ListTableBox;
        private System.Windows.Forms.Button DelRecordBtn;
        private System.Windows.Forms.Button UpdateDbBtn;
        private System.Windows.Forms.Button AddRecordBtn;
        private System.Windows.Forms.Button ChangeRecBtn;
        private System.Windows.Forms.Panel WorkWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip hints;
        private System.Windows.Forms.Button LoadExcelBtn;
        private System.Windows.Forms.Button SaveExcelBtn;
        private System.Windows.Forms.CheckBox HidePassBox;
        private System.Windows.Forms.Panel WorkControls;
        private System.Windows.Forms.ComboBox DbBox;
    }
}

