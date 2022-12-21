using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;

namespace Database
{
    public partial class ProgramWindow : Form
    {
        MySqlConnection dbcon;
        MySqlDataAdapter adr;

        public ProgramWindow()
        {
            InitializeComponent();
            WorkWindow.Hide();
            Database_GetList();
        }

        // Получение списка БД
        private void Database_GetList()
        {
            string myConnectionString = $"""
                SERVER=localhost;
                UID ='root';
                PASSWORD ='';
                """;

            string sqlCmd = "SHOW DATABASES;";

            try
            {
                using (dbcon = new MySqlConnection(myConnectionString))
                {
                    MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, dbcon);
                    adr.SelectCommand.CommandType = CommandType.Text;

                    DataSet recivedData = new DataSet();
                    adr.Fill(recivedData);

                    foreach (DataRow db in recivedData.Tables[0].Rows)
                        DbBox.Items.Add(db.ItemArray[0].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к базе :(", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Присоединение к базе данных
        private void Database_Connect()
        {
            string myConnectionString = $"""
                SERVER=localhost;
                UID ='{MySqlHelper.EscapeString(LoginTB.Text)}';
                PASSWORD ='{MySqlHelper.EscapeString(PassTB.Text)}';
                DATABASE ={DbBox.SelectedItem};
                """;

            string sqlCmd = $"SHOW TABLES";

            dbcon = new MySqlConnection(myConnectionString);
            
            MySqlDataAdapter adr = new MySqlDataAdapter(sqlCmd, dbcon);
            adr.SelectCommand.CommandType = CommandType.Text;

            DataSet recivedData = new DataSet();
            adr.Fill(recivedData);

            foreach (DataRow db in recivedData.Tables[0].Rows)
                ListTableBox.Items.Add(db.ItemArray[0].ToString());
        }

        // Переключение интерфейса
        private void Interface_Show(Control LoginBox, Control WorkWindow)
        {
            LoginBox.Hide();
            WorkWindow.Show();
        }

        // Очистка таблицы
        private void DataGrid_Clear()
        {
            RecordTable.DataSource = null;
            RecordTable.Rows.Clear();
            RecordTable.Columns.Clear();
        }

        // Вывод выбранной таблицы
        private void Records_Show(string table)
        {
            string sqlCmd = $"SELECT * FROM {table}";

            DataGrid_Clear();

            try
            {
                adr = new MySqlDataAdapter(sqlCmd, dbcon);
                adr.SelectCommand.CommandType = CommandType.Text;
            }
            catch
            {
                MessageBox.Show("Ошибка!\nНе удалось прочитать записи :(", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            adr.Fill(dt);

            RecordTable.DataSource = dt;
        }


        // Вход в систему
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Database_Connect();
            }
            catch
            {
                MessageBox.Show("Ошибка!\nНе удалось подключиться к базе :(", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Interface_Show(LoginBox, WorkWindow);
        }

        // Вывод записей выбранной таблицы
        private void ListTableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Records_Show(ListTableBox.SelectedItem.ToString());
            SaveExcelBtn.Enabled = true;
        }

        // Удаление записей
        private void Record_Delete()
        {
            var rows = RecordTable.SelectedRows;

            for (int i = rows.Count - 1; i >= 0; i--)
                RecordTable.Rows.RemoveAt(rows[i].Index);

            adr.DeleteCommand = new MySqlCommandBuilder(adr).GetDeleteCommand();

            try
            {
                adr.Update((DataTable)RecordTable.DataSource);
            }
            catch
            {
                MessageBox.Show("Не удалось удалить одну или несколько записей :(", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Records_Show(ListTableBox.SelectedItem.ToString());
            }
        }

        private void DelRecBtn_Click(object sender, EventArgs e)
        {
            if (ListTableBox.SelectedItem != null)
                Record_Delete();
            else
                MessageBox.Show("Вы не выбрали таблицу!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateDbBtn_Click(object sender, EventArgs e)
        {
            if (ListTableBox.SelectedItem != null)
                Records_Show(ListTableBox.SelectedItem.ToString());
            else
                MessageBox.Show("Вы не выбрали таблицу!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Включение и отключение элементов управления
        private void ButtonStatus_Change(Control active, bool mode)
        {
            foreach (var control in WorkControls.Controls)
            {
                if (control != active && control is not Label)
                {
                    if (control is Button)
                        ((Button)control).Enabled = mode;
                    else
                        ((ComboBox)control).Enabled = mode;
                }
            }
        }

        // Добавление записи
        private void Record_Add()
        {
            adr.InsertCommand = new MySqlCommandBuilder(adr).GetInsertCommand();

            try
            {
                adr.Update((DataTable)RecordTable.DataSource);
            }
            catch
            {
                MessageBox.Show("Не удалось добавить записи :(", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Records_Show(ListTableBox.SelectedItem.ToString());
            }
        }

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            if (ListTableBox.SelectedItem != null)
            {
                if (AddRecordBtn.Tag.Equals("Добавить запись"))
                {
                    AddRecordBtn.Tag = "Сохранить изменения";
                    AddRecordBtn.BackColor = System.Drawing.Color.Green;
                    RecordTable.AllowUserToAddRows = LoadExcelBtn.Enabled = true;
                    RecordTable.ReadOnly = false;

                    ButtonStatus_Change(AddRecordBtn, false);
                }
                else
                {
                    Record_Add();
                    AddRecordBtn.Tag = "Добавить запись";
                    AddRecordBtn.BackColor = System.Drawing.Color.FromName("ControlLight");
                    RecordTable.AllowUserToAddRows = LoadExcelBtn.Enabled = false;
                    RecordTable.ReadOnly = true;

                    ButtonStatus_Change(AddRecordBtn, true);
                }
            }
            else
                MessageBox.Show("Вы не выбрали таблицу!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Изменение записи
        private void ChangeRecord()
        {
            adr.UpdateCommand = new MySqlCommandBuilder(adr).GetUpdateCommand();

            try
            {
                adr.Update((DataTable)RecordTable.DataSource);
            }
            catch
            {
                MessageBox.Show("Не удалось изменить запись :(", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Records_Show(ListTableBox.SelectedItem.ToString());
            }
        }

        private void ChangeRecBtn_Click(object sender, EventArgs e)
        {
            if (ListTableBox.SelectedItem != null)
            {
                if (ChangeRecBtn.Tag.Equals("Редактировать запись"))
                {
                    ChangeRecBtn.Tag = "Выйти из режима редактирования";
                    ChangeRecBtn.BackColor = System.Drawing.Color.Green;
                    RecordTable.ReadOnly = false;

                    ButtonStatus_Change(ChangeRecBtn, false);
                }
                else
                {
                    ChangeRecord();
                    ChangeRecBtn.Tag = "Редактировать запись";
                    ChangeRecBtn.BackColor = System.Drawing.Color.FromName("ControlLight");
                    RecordTable.ReadOnly = true;

                    ButtonStatus_Change(ChangeRecBtn, true);
                }
            }
            else
                MessageBox.Show("Вы не выбрали таблицу!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Загрузка таблицы из Excel
        private void LoadEx()
        {
            using (OpenFileDialog openfile = new OpenFileDialog()
            {
                Filter = "|*.xlsx",
                InitialDirectory = @"~\%user%\Рабочий стол"
            })
            {
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook(openfile.FileName))
                        {
                            IXLWorksheet worksheet = workbook.Worksheet(1);

                            int tl_Row = worksheet.FirstCellUsed().Address.RowNumber;
                            int tl_Col = worksheet.FirstCellUsed().Address.ColumnNumber;
                            int br_Row = worksheet.LastCellUsed().Address.RowNumber;
                            int br_Col = worksheet.LastCellUsed().Address.ColumnNumber;

                            IXLRow currentRow;
                            DataTable dt = new DataTable();
                            dt = (DataTable)RecordTable.DataSource;

                            for (int dtRow = 0; dtRow < br_Row - tl_Row; dtRow++)
                            {
                                DataRow row = dt.NewRow();
                                currentRow = worksheet.Row(tl_Row + dtRow + 1);

                                for (int dtCol = 0; dtCol < br_Col - tl_Col + 1; dtCol++)
                                    row[dtCol] = currentRow.Cell(tl_Col + dtCol).CachedValue;

                                dt.Rows.Add(row);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка при загрузке данных :(", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Records_Show(ListTableBox.SelectedItem.ToString());
                        return;
                    }
                }
            }
        }

        // Сохранение таблицы в Excel
        private void SaveEx()
        {
            using (SaveFileDialog savefile = new SaveFileDialog() { Filter = "|*.xlsx", FileName = $"{ListTableBox.SelectedItem}" })
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add((DataTable)RecordTable.DataSource, ListTableBox.SelectedItem.ToString());
                            workbook.SaveAs(savefile.FileName);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка при сохранении данных :(", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        // Выход из учетной записи
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            dbcon.Close();
            Interface_Show(WorkWindow, LoginBox);

            HidePassBox.Checked = false;
            SaveExcelBtn.Enabled = false;
            RecordTable.ReadOnly = true;

            ListTableBox.Text = string.Empty;
            PassTB.Text = string.Empty;

            ListTableBox.Items.Clear();

            RecordTable.DataSource = null;
            RecordTable.Rows.Clear();
            RecordTable.Columns.Clear();
        }

        private void PassTB_TextChanged(object sender, EventArgs e)
        {
            if (LoginTB.Text == string.Empty || PassTB.Text == string.Empty || DbBox.SelectedItem == null)
                LoginBtn.Enabled = false;
            else
                LoginBtn.Enabled = true;
        }

        private void LoginTB_TextChanged(object sender, EventArgs e)
        {
            if (LoginTB.Text == string.Empty || DbBox.SelectedItem == null)
                LoginBtn.Enabled = false;
            else
                LoginBtn.Enabled = true;
        }

        private void SaveExcelBtn_Click(object sender, EventArgs e)
        {
            SaveEx();
        }

        private void LoadExcelBtn_Click(object sender, EventArgs e)
        {
            LoadEx();
        }

        private void RecordTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        private void HidePassBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HidePassBox.Checked)
                PassTB.UseSystemPasswordChar = false;    
            else   
                PassTB.UseSystemPasswordChar = true;     
        }

        private void DbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoginTB.Text == string.Empty || DbBox.SelectedItem == null)
                LoginBtn.Enabled = false;
            else
                LoginBtn.Enabled = true;
        }

        private void ProgramWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dbcon != null)
                dbcon.Clone();
        }
    }
}