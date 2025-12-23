using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization;

namespace Tyuiu.ChuginNM.Sprint7.Project.V2
{
    partial class FormMain_CNM
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_CNM));
            groupBoxControl_CNM = new GroupBox();
            buttonCreateFile_CNM = new Button();
            buttonSaveFile_CNM = new Button();
            buttonOpenFile_CNM = new Button();
            groupBoxMathFunc_CNM = new GroupBox();
            buttonCellMean_CNM = new Button();
            buttonCellMin_CNM = new Button();
            buttonCellMax_CNM = new Button();
            buttonCellSum_CNM = new Button();
            groupBoxHelp_CNM = new GroupBox();
            buttonHelp_CNM = new Button();
            dataGridViewOutput_CNM = new DataGridView();
            toolTipHelper_CNM = new ToolTip(components);
            textBoxCellCount_CNM = new TextBox();
            groupBoxControl_CNM.SuspendLayout();
            groupBoxMathFunc_CNM.SuspendLayout();
            groupBoxHelp_CNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_CNM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxControl_CNM
            // 
            groupBoxControl_CNM.Controls.Add(buttonCreateFile_CNM);
            groupBoxControl_CNM.Controls.Add(buttonSaveFile_CNM);
            groupBoxControl_CNM.Controls.Add(buttonOpenFile_CNM);
            groupBoxControl_CNM.Location = new Point(12, 12);
            groupBoxControl_CNM.Name = "groupBoxControl_CNM";
            groupBoxControl_CNM.Size = new Size(272, 121);
            groupBoxControl_CNM.TabIndex = 0;
            groupBoxControl_CNM.TabStop = false;
            groupBoxControl_CNM.Text = "Управление";
            // 
            // buttonCreateFile_CNM
            // 
            buttonCreateFile_CNM.AutoSize = true;
            buttonCreateFile_CNM.BackgroundImage = (Image)resources.GetObject("buttonCreateFile_CNM.BackgroundImage");
            buttonCreateFile_CNM.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCreateFile_CNM.ImageAlign = ContentAlignment.TopCenter;
            buttonCreateFile_CNM.Location = new Point(91, 22);
            buttonCreateFile_CNM.Name = "buttonCreateFile_CNM";
            buttonCreateFile_CNM.Size = new Size(81, 77);
            buttonCreateFile_CNM.TabIndex = 2;
            buttonCreateFile_CNM.TextAlign = ContentAlignment.BottomCenter;
            toolTipHelper_CNM.SetToolTip(buttonCreateFile_CNM, "Создать новую таблицу");
            buttonCreateFile_CNM.UseVisualStyleBackColor = true;
            buttonCreateFile_CNM.Click += ButtonCreateFile_CNM_Click;
            // 
            // buttonSaveFile_CNM
            // 
            buttonSaveFile_CNM.AutoSize = true;
            buttonSaveFile_CNM.BackgroundImage = Properties.Resources.icons8_save_file_100;
            buttonSaveFile_CNM.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveFile_CNM.ImageAlign = ContentAlignment.TopCenter;
            buttonSaveFile_CNM.Location = new Point(178, 22);
            buttonSaveFile_CNM.Name = "buttonSaveFile_CNM";
            buttonSaveFile_CNM.Size = new Size(81, 77);
            buttonSaveFile_CNM.TabIndex = 1;
            buttonSaveFile_CNM.TextAlign = ContentAlignment.BottomCenter;
            toolTipHelper_CNM.SetToolTip(buttonSaveFile_CNM, "Сохранить файл");
            buttonSaveFile_CNM.UseVisualStyleBackColor = true;
            buttonSaveFile_CNM.Click += ButtonSaveFile_CNM_Click;
            // 
            // buttonOpenFile_CNM
            // 
            buttonOpenFile_CNM.AutoSize = true;
            buttonOpenFile_CNM.BackgroundImage = Properties.Resources.icons8_search_folder_100;
            buttonOpenFile_CNM.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile_CNM.Location = new Point(6, 22);
            buttonOpenFile_CNM.Name = "buttonOpenFile_CNM";
            buttonOpenFile_CNM.Size = new Size(79, 77);
            buttonOpenFile_CNM.TabIndex = 0;
            buttonOpenFile_CNM.TextAlign = ContentAlignment.BottomCenter;
            buttonOpenFile_CNM.TextImageRelation = TextImageRelation.ImageAboveText;
            toolTipHelper_CNM.SetToolTip(buttonOpenFile_CNM, "Открыть файл");
            buttonOpenFile_CNM.UseVisualStyleBackColor = true;
            buttonOpenFile_CNM.Click += ButtonOpenFile_CNM_Click;
            // 
            // groupBoxMathFunc_CNM
            // 
            groupBoxMathFunc_CNM.Controls.Add(buttonCellMean_CNM);
            groupBoxMathFunc_CNM.Controls.Add(buttonCellMin_CNM);
            groupBoxMathFunc_CNM.Controls.Add(buttonCellMax_CNM);
            groupBoxMathFunc_CNM.Controls.Add(buttonCellSum_CNM);
            groupBoxMathFunc_CNM.Location = new Point(290, 12);
            groupBoxMathFunc_CNM.Name = "groupBoxMathFunc_CNM";
            groupBoxMathFunc_CNM.Size = new Size(177, 121);
            groupBoxMathFunc_CNM.TabIndex = 2;
            groupBoxMathFunc_CNM.TabStop = false;
            groupBoxMathFunc_CNM.Text = "Математика";
            // 
            // buttonCellMean_CNM
            // 
            buttonCellMean_CNM.Location = new Point(85, 82);
            buttonCellMean_CNM.Name = "buttonCellMean_CNM";
            buttonCellMean_CNM.Size = new Size(86, 23);
            buttonCellMean_CNM.TabIndex = 3;
            buttonCellMean_CNM.Text = "Ср. Знач.";
            toolTipHelper_CNM.SetToolTip(buttonCellMean_CNM, "Находит среднее арифметическое выделенных ячеек.");
            buttonCellMean_CNM.UseVisualStyleBackColor = true;
            buttonCellMean_CNM.Click += ButtonCellMean_CNM_Click;
            // 
            // buttonCellMin_CNM
            // 
            buttonCellMin_CNM.Location = new Point(85, 53);
            buttonCellMin_CNM.Name = "buttonCellMin_CNM";
            buttonCellMin_CNM.Size = new Size(86, 23);
            buttonCellMin_CNM.TabIndex = 2;
            buttonCellMin_CNM.Text = "Минимум";
            toolTipHelper_CNM.SetToolTip(buttonCellMin_CNM, "Находит минимальное число в выделенных ячейках");
            buttonCellMin_CNM.UseVisualStyleBackColor = true;
            buttonCellMin_CNM.Click += ButtonCellMin_CNM_Click;
            // 
            // buttonCellMax_CNM
            // 
            buttonCellMax_CNM.Location = new Point(85, 24);
            buttonCellMax_CNM.Name = "buttonCellMax_CNM";
            buttonCellMax_CNM.Size = new Size(86, 23);
            buttonCellMax_CNM.TabIndex = 1;
            buttonCellMax_CNM.Text = "Максимум";
            toolTipHelper_CNM.SetToolTip(buttonCellMax_CNM, "Находит максимальное число в выделенных ячейках");
            buttonCellMax_CNM.UseVisualStyleBackColor = true;
            buttonCellMax_CNM.Click += ButtonCellMax_CNM_Click;
            // 
            // buttonCellSum_CNM
            // 
            buttonCellSum_CNM.Location = new Point(6, 24);
            buttonCellSum_CNM.Name = "buttonCellSum_CNM";
            buttonCellSum_CNM.Size = new Size(73, 81);
            buttonCellSum_CNM.TabIndex = 0;
            buttonCellSum_CNM.Text = "Сумма ячеек";
            toolTipHelper_CNM.SetToolTip(buttonCellSum_CNM, "Находит сумму чисел в выделенных ячейках");
            buttonCellSum_CNM.UseVisualStyleBackColor = true;
            buttonCellSum_CNM.Click += ButtonCellSum_CNM_Click;
            // 
            // groupBoxHelp_CNM
            // 
            groupBoxHelp_CNM.Controls.Add(buttonHelp_CNM);
            groupBoxHelp_CNM.Location = new Point(491, 12);
            groupBoxHelp_CNM.Name = "groupBoxHelp_CNM";
            groupBoxHelp_CNM.Size = new Size(93, 121);
            groupBoxHelp_CNM.TabIndex = 3;
            groupBoxHelp_CNM.TabStop = false;
            // 
            // buttonHelp_CNM
            // 
            buttonHelp_CNM.AutoSize = true;
            buttonHelp_CNM.BackgroundImage = Properties.Resources.icons8_documents_100;
            buttonHelp_CNM.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHelp_CNM.ImageAlign = ContentAlignment.TopCenter;
            buttonHelp_CNM.Location = new Point(6, 22);
            buttonHelp_CNM.Name = "buttonHelp_CNM";
            buttonHelp_CNM.Size = new Size(81, 77);
            buttonHelp_CNM.TabIndex = 2;
            buttonHelp_CNM.TextAlign = ContentAlignment.BottomCenter;
            buttonHelp_CNM.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOutput_CNM
            // 
            dataGridViewOutput_CNM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOutput_CNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_CNM.Location = new Point(12, 139);
            dataGridViewOutput_CNM.Name = "dataGridViewOutput_CNM";
            dataGridViewOutput_CNM.Size = new Size(572, 462);
            dataGridViewOutput_CNM.TabIndex = 4;
            dataGridViewOutput_CNM.SelectionChanged += DataGridViewOutput_CNM_SelectionChanged;
            // 
            // textBoxCellCount_CNM
            // 
            textBoxCellCount_CNM.BackColor = SystemColors.Control;
            textBoxCellCount_CNM.BorderStyle = BorderStyle.None;
            textBoxCellCount_CNM.Location = new Point(12, 607);
            textBoxCellCount_CNM.Name = "textBoxCellCount_CNM";
            textBoxCellCount_CNM.Size = new Size(572, 16);
            textBoxCellCount_CNM.TabIndex = 5;
            textBoxCellCount_CNM.TextAlign = HorizontalAlignment.Right;
            // 
            // FormMain_CNM
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(602, 645);
            Controls.Add(textBoxCellCount_CNM);
            Controls.Add(dataGridViewOutput_CNM);
            Controls.Add(groupBoxHelp_CNM);
            Controls.Add(groupBoxMathFunc_CNM);
            Controls.Add(groupBoxControl_CNM);
            Name = "FormMain_CNM";
            Text = "Спринт 7 | Проект | Вариант 2 | Чугин Н.М.";
            groupBoxControl_CNM.ResumeLayout(false);
            groupBoxControl_CNM.PerformLayout();
            groupBoxMathFunc_CNM.ResumeLayout(false);
            groupBoxHelp_CNM.ResumeLayout(false);
            groupBoxHelp_CNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_CNM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormMain_CNM_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxControl_CNM;
        private Button buttonOpenFile_CNM;
        private Button buttonSaveFile_CNM;
        private GroupBox groupBoxMathFunc_CNM;
        private GroupBox groupBoxHelp_CNM;
        private Button buttonHelp_CNM;
        private DataGridView dataGridViewOutput_CNM;
        private Button buttonCreateFile_CNM;
        private ToolTip toolTipHelper_CNM;
        private Button buttonCellMin_CNM;
        private Button buttonCellMax_CNM;
        private Button buttonCellSum_CNM;
        private Button buttonCellMean_CNM;
        private TextBox textBoxCellCount_CNM;
    }
}
