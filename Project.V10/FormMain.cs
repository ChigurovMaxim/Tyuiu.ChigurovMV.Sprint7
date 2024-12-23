using System.Windows.Forms;
using Tyuiu.ChigurovMV.Sprint7.Project.V10.Lib;
namespace Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_CMV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_CMV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        string openFilePath;
        public bool fileOpened = false;

        //Общая функция поиска
        public void Search(DataGridView dataGrid, string searchValue, int searchableValue)
        {
            dataGrid.ClearSelection();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[searchableValue].Value.ToString().ToUpper() == searchValue)
                {
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Selected = true;
                    }
                }
            }
        }

        //Общее сокрытие рядов
        public void InvisibleRowsByColors(DataGridView dataGrid, Color color, bool rowVisibility)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Style.BackColor == color)
                {
                    row.Visible = rowVisibility;
                }
            }
        }

        private void AddedRowsToolStripMenuItem_CMV_CheckedChanged(object sender, EventArgs e)
        {

            if (AddedRowsToolStripMenuItem_CMV.Checked)
            {
                InvisibleRowsByColors(dataGridViewEdit_CMV, Color.Aqua, true);
            }
            else
            {
                InvisibleRowsByColors(dataGridViewEdit_CMV, Color.Aqua, false);
            }
        }

        private void DeletedRowsToolStripMenuItem_CMV_CheckedChanged(object sender, EventArgs e)
        {

            if (DeletedRowsToolStripMenuItem_CMV.Checked)
            {
                InvisibleRowsByColors(dataGridViewEdit_CMV, Color.OrangeRed, true);
            }
            else
            {
                InvisibleRowsByColors(dataGridViewEdit_CMV, Color.OrangeRed, false);
            }
        }

        //Переключение видимости кнопок редактирования строк
        private void tabControlTable_CMV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlTable_CMV.SelectedIndex == 1 && fileOpened)
            {
                this.buttonAddRow_CMV.Enabled = true;
                this.buttonDeleteMarkedRow_CMV.Enabled = true;
                checkBoxMarkRow_CMV.Enabled = true;
                filterToolStripMenuItem_CMV.Enabled = true;
                if (checkBoxMarkRow_CMV.Checked)
                {
                    buttonMarkDelete_CMV.Enabled = true;
                    buttonUnmarkDelete_CMV.Enabled = true;
                }

            }
            else
            {
                filterToolStripMenuItem_CMV.Enabled = false;
                this.buttonAddRow_CMV.Enabled = false;
                this.buttonDeleteMarkedRow_CMV.Enabled = false;
                checkBoxMarkRow_CMV.Enabled = false;
                buttonMarkDelete_CMV.Enabled = false;
                buttonUnmarkDelete_CMV.Enabled = false;
            }
        }

        //Поиск
        private void buttonReadOnlySearchOrderID_CMV_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxReadOnlySearchOrderID_CMV.Text;
            Search(dataGridViewReadOnly_CMV, searchValue, 0);
        }
        private void buttonReadOnlySearchUserID_CMV_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxReadOnlySearchUserID_CMV.Text;
            Search(dataGridViewReadOnly_CMV, searchValue, 1);
        }
        private void buttonEditSearchOrderID_CMV_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxEditSearchOrderID_CMV.Text;
            Search(dataGridViewEdit_CMV, searchValue, 0);
        }
        private void buttonEditSearchUserID_CMV_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxEditSearchUserID_CMV.Text;
            Search(dataGridViewEdit_CMV, searchValue, 1);
        }


        private void checkBoxMarkRow_CMV_Checked(object sender, EventArgs e)
        {
            if (checkBoxMarkRow_CMV.CheckState == CheckState.Checked)
            {
                buttonMarkDelete_CMV.Enabled = true;
                buttonUnmarkDelete_CMV.Enabled = true;
                dataGridViewEdit_CMV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                buttonMarkDelete_CMV.Enabled = false;
                buttonUnmarkDelete_CMV.Enabled = false;
                dataGridViewEdit_CMV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        //Добавление строки
        private void buttonAdd_CMV_Click(object sender, EventArgs e)
        {
            dataGridViewEdit_CMV.Rows.Add(0, 0, "01.01.2025", "НЕИЗВЕСТНО", 0, "НЕИЗВЕСТНО", 0, 0);
            foreach (DataGridViewCell cell in dataGridViewEdit_CMV.Rows[^1].Cells)
            {
                cell.Style.BackColor = Color.Aqua;
            }
        }
        //Окрашивание ячейки при изменении
        private void dataGridViewEdit_CMV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_CMV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var previousValue = dataGridViewEdit_CMV.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                if (previousValue == null || !cell.Value.Equals(previousValue))
                {
                    cell.Style.BackColor = Color.Green;
                }

                cell.Tag = cell.Value;
            }
        }

        private void dataGridViewEdit_CMV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_CMV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Tag = cell.Value;
            }
        }
        //Проверка на пустое содержание ячейки
        private void dataGridViewEdit_CMV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_CMV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;

                    cell.Value = cell.Tag;
                }
            }
        }

        //Покраска выделенных ячеек на удаление
        private void buttonMarkDelete_CMV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEdit_CMV.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.OrangeRed;
                }
            }
        }

        //Удаление строки
        private void buttonDeleteMarkedRow_CMV_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить выделенные ряды? Это действие необратимо.", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                for (int i = dataGridViewEdit_CMV.Rows.Count - 1; i >= 0; i--)
                {
                    if (dataGridViewEdit_CMV.Rows[i].Cells[0].Style.BackColor == Color.OrangeRed)
                    {
                        dataGridViewEdit_CMV.Rows.RemoveAt(i);
                    }
                }
            }
        }

        //Убирание покраски удаления
        private void buttonUnmarkDelete_CMV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEdit_CMV.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.OrangeRed)
                    {
                        cell.Style.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                    }
                }
            }
        }
        //Открытие файла
        private void buttonOpenFile_CMV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            openFileDialogTask_CMV.ShowDialog();
            openFilePath = openFileDialogTask_CMV.FileName;

            string[,] arrayValues = ds.GetMatrix(openFilePath);

            dataGridViewReadOnly_CMV.RowCount = arrayValues.GetLength(0);
            dataGridViewEdit_CMV.RowCount = arrayValues.GetLength(0);

            dataGridViewReadOnly_CMV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEdit_CMV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            buttonSaveFile_CMV.Enabled = true;
            fileOpened = true;

            for (int i = 0; i < dataGridViewReadOnly_CMV.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewReadOnly_CMV.Columns.Count; j++)
                {
                    if (j == 0 || j == 1 || j == 4 || j == 6 || j == 7)
                    {
                        dataGridViewEdit_CMV.Rows[i].Cells[j].Value = Convert.ToInt32(arrayValues[i, j]);
                        dataGridViewReadOnly_CMV.Rows[i].Cells[j].Value = Convert.ToInt32(arrayValues[i, j]);
                        dataGridViewEdit_CMV.Columns[j].ValueType = typeof(int);
                    }
                    else if (j == 2)
                    {
                        DateOnly date;
                        date = DateOnly.ParseExact(arrayValues[i, j], "dd.MM.yyyy", null);
                        dataGridViewEdit_CMV.Rows[i].Cells[j].Value = date;
                        dataGridViewReadOnly_CMV.Rows[i].Cells[j].Value = date;
                    }
                    else
                    {
                        dataGridViewEdit_CMV.Rows[i].Cells[j].Value = arrayValues[i, j].ToUpper();
                        dataGridViewReadOnly_CMV.Rows[i].Cells[j].Value = arrayValues[i, j].ToUpper();
                        dataGridViewEdit_CMV.Columns[j].ValueType = typeof(string);
                    }
                }
            }
            foreach (DataGridViewRow row in dataGridViewEdit_CMV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Tag = null;
                }
            }
        }

        private void buttonSaveFile_CMV_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_CMV.FileName = "SaveDataFile.csv";
            saveFileDialogTask_CMV.InitialDirectory = @"C:\DataSprint7";
            saveFileDialogTask_CMV.ShowDialog();

            string path = saveFileDialogTask_CMV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < dataGridViewEdit_CMV.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewEdit_CMV.ColumnCount; j++)
                {
                    if (dataGridViewEdit_CMV.Rows[i].Cells[j].Style.BackColor == Color.Orange) break;

                    if (j != dataGridViewEdit_CMV.ColumnCount - 1)
                    {
                        str += dataGridViewEdit_CMV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewEdit_CMV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void statsToolStripMenuItem_CMV_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic(dataGridViewEdit_CMV);
            formStatistic.ShowDialog();
        }

        private void infoToolStripMenuItem_CMV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void руководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
    }
}
