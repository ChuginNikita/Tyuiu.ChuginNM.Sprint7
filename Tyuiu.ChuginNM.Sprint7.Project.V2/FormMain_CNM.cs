using System.Text;
using System.Windows.Forms;
using Tyuiu.ChuginNM.Sprint7.Project.V2.Lib;
using static Tyuiu.ChuginNM.Sprint7.Project.V2.formTypeSelection_CNM;

namespace Tyuiu.ChuginNM.Sprint7.Project.V2
{
    public partial class FormMain_CNM : Form
    {

        public FormMain_CNM()
        {
            InitializeComponent();
        }

        private void ButtonSaveFile_CNM_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewOutput_CNM.Rows.Count == 0))
            {
                SaveDataGridViewToCSV(dataGridViewOutput_CNM);
            }
            else { MessageBox.Show("Таблица пуста и/или несуществует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

        }

        private void ButtonCellMean_CNM_Click(object sender, EventArgs e)
        {
            MeanCellValue(dataGridViewOutput_CNM);
        }

        private void ButtonOpenFile_CNM_Click(object sender, EventArgs e) // Открытие файла по кнопке
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }


            }

            if (filePath != string.Empty) { MatrixToGrid(dataGridViewOutput_CNM, DataService.GetMatrix(filePath)); }



        }

        private void ButtonCreateFile_CNM_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_CNM.Rows.Clear();
            dataGridViewOutput_CNM.Columns.Clear();
            using (var tableTypeDialog = new formTypeSelection_CNM())
            {
                if (tableTypeDialog.ShowDialog() == DialogResult.OK)
                {
                    CreateTableInDataGridView(tableTypeDialog.SelectedTableType);
                }
            }
        }

        private void ButtonCellSum_CNM_Click(object sender, EventArgs e)
        {
            SumSelectedCells(dataGridViewOutput_CNM);
        }

        private void ButtonCellMin_CNM_Click(object sender, EventArgs e)
        {
            CellMinMax(dataGridViewOutput_CNM, "min");
        }

        private void ButtonCellMax_CNM_Click(object sender, EventArgs e)
        {
            CellMinMax(dataGridViewOutput_CNM, "max");
        }

        private void ButtonHelp_CNM_Click(object sender, EventArgs e)
        {
            FormAbout_CNM run = new FormAbout_CNM();
            run.ShowDialog();
            run.Close();
        }

        private void DataGridViewOutput_CNM_SelectionChanged(object sender, EventArgs e)
        {
            int selectedCellCount = dataGridViewOutput_CNM.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 1)
            {
                textBoxCellCount_CNM.Text = $"Выделено ячеек: {selectedCellCount}";
            }
            else { textBoxCellCount_CNM.Clear(); }
        }


        // Дальше бога нет

        public void CreateTableInDataGridView(TableType tableType) // buttonCreateFile -> dataGridView
        {
            dataGridViewOutput_CNM.Columns.Clear();

            switch (tableType)
            {
                case TableType.Owners:
                    dataGridViewOutput_CNM.Columns.Add("Number", "Номер");
                    dataGridViewOutput_CNM.Columns.Add("FullName", "ФИО");
                    dataGridViewOutput_CNM.Columns.Add("Address", "Адрес");
                    dataGridViewOutput_CNM.Columns.Add("OwnerPhone", "Телефон владельца");
                    break;

                case TableType.Stores:
                    dataGridViewOutput_CNM.Columns.Add("Number", "Номер");
                    dataGridViewOutput_CNM.Columns.Add("StoreName", "Название магазина");
                    dataGridViewOutput_CNM.Columns.Add("Address", "Адрес");
                    dataGridViewOutput_CNM.Columns.Add("OwnerPhone", "Телефон владельца");
                    break;

                case TableType.Suppliers:
                    dataGridViewOutput_CNM.Columns.Add("Number", "Номер");
                    dataGridViewOutput_CNM.Columns.Add("Supplier", "Поставщик");
                    dataGridViewOutput_CNM.Columns.Add("Product", "Поставляемый товар");
                    dataGridViewOutput_CNM.Columns.Add("Quantity", "Количество товара");
                    dataGridViewOutput_CNM.Columns.Add("Price", "Цена за единицу / килограмм");
                    break;
            }

            dataGridViewOutput_CNM.Rows.Add();
        }

        public void MatrixToGrid(DataGridView dataGridView, string[,] matrix) // GetMatrix -> dataGridView
        {
            try
            {
                if (matrix == null || matrix.Length == 0)
                {
                    MessageBox.Show("Матрица пустая или не инициализирована.",
                                  "Ошибка",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                int totalRows = matrix.GetLength(0);
                int totalCols = matrix.GetLength(1);

                if (totalRows < 1 || totalCols < 1)
                {
                    MessageBox.Show("Матрица имеет недопустимые размеры.",
                                  "Ошибка",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(matrix[0, 0]) ||
                    !matrix[0, 0].Trim().Equals("Номер", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Заголовок не соответствует шаблону",
                                  "Ошибка формата",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                dataGridView.Columns.Clear();
                dataGridView.Rows.Clear();
                dataGridView.DataSource = null;

                for (int col = 0; col < totalCols; col++)
                {
                    string headerText = matrix[0, col];

                    if (string.IsNullOrEmpty(headerText))
                    {
                        headerText = $"Столбец {col + 1}";
                    }

                    dataGridView.Columns.Add($"Column_{col}", headerText);
                }

                for (int row = 1; row < totalRows; row++)
                {

                    object[] rowValues = new object[totalCols];

                    for (int col = 0; col < totalCols; col++)
                    {
                        rowValues[col] = matrix[row, col];
                    }

                    dataGridView.Rows.Add(rowValues);
                }

                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                if (dataGridView.Rows.Count > 0)
                {
                    dataGridView.Rows[0].Selected = false;
                }

                MessageBox.Show($"Матрица успешно загружена.",
                               "Успех",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обработке матрицы:\n{ex.Message}",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        public void SaveDataGridViewToCSV(DataGridView dataGridView) // buttonSaveFile -> *.csv
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.Title = "Сохранить таблицу";
                    saveFileDialog.DefaultExt = "csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                        {

                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                writer.Write(dataGridView.Columns[i].HeaderText);
                                if (i < dataGridView.Columns.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }
                            writer.WriteLine();

                            for (int row = 0; row < dataGridView.Rows.Count; row++)
                            {

                                if (dataGridView.Rows[row].IsNewRow) continue;

                                for (int col = 0; col < dataGridView.Columns.Count; col++)
                                {
                                    object value = dataGridView.Rows[row].Cells[col].Value;

                                    string stringValue = value?.ToString() ?? "";

                                    if (stringValue.Contains(",") || stringValue.Contains("\"") ||
                                        stringValue.Contains("\r") || stringValue.Contains("\n"))
                                    {
                                        stringValue = "\"" + stringValue.Replace("\"", "\"\"") + "\"";
                                    }

                                    writer.Write(stringValue);

                                    if (col < dataGridView.Columns.Count - 1)
                                    {
                                        writer.Write(",");
                                    }
                                }
                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show($"Файл успешно сохранен: {filePath}",
                                      "Сохранение завершено",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Винда сказала, что файл сохранить нельзя ({ex.Message})",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        public void SumSelectedCells(DataGridView dataGridView) // Выделенные ячейки сумируются в MessageBox
        {
            if (dataGridView == null)
            {
                MessageBox.Show("DataGridView не указан.", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double sum = 0;
            int processedCellsCount = 0;
            int errorCellsCount = 0;
            string errorMessage = "";

            var selectedCells = dataGridView.SelectedCells;

            if (selectedCells.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одной ячейки.", "Информация",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewCell cell in selectedCells)
            {

                if (cell != null && !cell.OwningRow.IsNewRow)
                {
                    string cellValue = cell.Value?.ToString();

                    if (string.IsNullOrWhiteSpace(cellValue))
                    {
                        continue;
                    }

                    if (double.TryParse(cellValue,
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.CurrentCulture,
                        out double numericValue))
                    {
                        sum += numericValue;
                        processedCellsCount++;
                    }
                    else
                    {
                        errorCellsCount++;

                        if (errorCellsCount <= 5)
                        {
                            if (!string.IsNullOrEmpty(errorMessage))
                                errorMessage += "\n";

                            errorMessage += $"Ячейка [{cell.RowIndex + 1}, {cell.ColumnIndex + 1}]: '{cellValue}'";
                        }
                    }
                }
            }

            if (errorCellsCount > 0)
            {
                string fullErrorMessage = "Выделенные ячейки содержат строковые значения, пожалуйста, повторите попытку.\n(Возможно, вы выделили неформатное значение?)";

                MessageBox.Show(fullErrorMessage, "Ошибка преобразования",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultMessage = $"Сумма выделенных ячеек: {sum:F2}\n" +
                                  $"Обработано ячеек: {processedCellsCount}";

            if (errorCellsCount > 0)
            {
                resultMessage += $"\nПропущено ячеек: {errorCellsCount}";
            }

            MessageBox.Show(resultMessage, "Результат",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CellMinMax(DataGridView dataGridView, string methodMode) // Тоже самое, что сверху, но страшно
        {
            if (dataGridView == null)
            {
                MessageBox.Show("DataGridView не указан!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("Нет выделенных ячеек!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<double> values = new List<double>();
            List<string> invalidCells = new List<string>();

            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                string cellValue = cell.Value?.ToString();

                if (string.IsNullOrWhiteSpace(cellValue))
                    continue;

                if (double.TryParse(cellValue, out double numericValue))
                {
                    values.Add(numericValue);
                }
                else
                {
                    invalidCells.Add($"Строка {cell.RowIndex + 1}, Колонка {cell.ColumnIndex + 1}: '{cellValue}'");
                }
            }

            if (invalidCells.Count > 0)
            {
                string errorMessage = "Выделенные ячейки содержат строковые значения, пожалуйста, повторите попытку.\n(Возможно, вы выделили неформатное значение?)";

                MessageBox.Show(errorMessage, "Ошибка преобразования",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (values.Count == 0)
            {
                MessageBox.Show("В выделенных ячейках нет числовых значений!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result;
            string operationName;

            switch (methodMode.ToLower())
            {
                case "min":
                    result = values.Min();
                    operationName = "Минимальное";
                    break;

                case "max":
                    result = values.Max();
                    operationName = "Максимальное";
                    break;

                default:
                    MessageBox.Show($"Неизвестный режим: {methodMode}. Используйте 'min' или 'max'.",
                                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            MessageBox.Show($"{operationName} значение: {result}\n" +
                           $"Количество обработанных ячеек: {values.Count}",
                           "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MeanCellValue(DataGridView dataGridView) // Среднее значение
        {
            if (dataGridView.SelectedCells.Count == 0)
                return;

            double sum = 0;
            int count = 0;

            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                if (cell.Value != null)
                {
                    string cellValue = cell.Value.ToString();

                    // Если ячейка содержит текст, который нельзя конвертировать
                    if (!double.TryParse(cellValue, out double numericValue))
                    {
                        MessageBox.Show("Выделенные ячейки содержат строковые значения, пожалуйста, повторите попытку.\n (Возможно, вы выделили неформатное значение?)",
                                       "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Выходим из метода сразу при обнаружении ошибки
                    }

                    sum += numericValue;
                    count++;
                }
            }

            if (count > 0)
            {
                double average = sum / count;
                MessageBox.Show($"Среднее значение: {average:F2}\n" +
                               $"Обработано ячеек: {count}",
                               "Результат",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не найдено числовых значений в выделенных ячейках.",
                               "Информация",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormMain_CNM_Load_1(object sender, EventArgs e)
        {

        }
    }
}
