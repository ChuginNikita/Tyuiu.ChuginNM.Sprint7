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
            groupBoxControl_CNM = new GroupBox();
            buttonSaveFile_CNM = new Button();
            buttonOpenFile_CNM = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBoxControl_CNM.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxControl_CNM
            // 
            groupBoxControl_CNM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxControl_CNM.AutoSize = true;
            groupBoxControl_CNM.Controls.Add(buttonSaveFile_CNM);
            groupBoxControl_CNM.Controls.Add(buttonOpenFile_CNM);
            groupBoxControl_CNM.Location = new Point(12, 12);
            groupBoxControl_CNM.Name = "groupBoxControl_CNM";
            groupBoxControl_CNM.Size = new Size(178, 121);
            groupBoxControl_CNM.TabIndex = 0;
            groupBoxControl_CNM.TabStop = false;
            groupBoxControl_CNM.Text = "Управление";
            // 
            // buttonSaveFile_CNM
            // 
            buttonSaveFile_CNM.AutoSize = true;
            buttonSaveFile_CNM.BackgroundImage = Properties.Resources.icons8_save_file_100;
            buttonSaveFile_CNM.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveFile_CNM.ImageAlign = ContentAlignment.TopCenter;
            buttonSaveFile_CNM.Location = new Point(91, 22);
            buttonSaveFile_CNM.Name = "buttonSaveFile_CNM";
            buttonSaveFile_CNM.Size = new Size(81, 77);
            buttonSaveFile_CNM.TabIndex = 1;
            buttonSaveFile_CNM.TextAlign = ContentAlignment.BottomCenter;
            buttonSaveFile_CNM.UseVisualStyleBackColor = true;
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
            buttonOpenFile_CNM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Location = new Point(196, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(919, 121);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Функционал";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(1121, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(93, 121);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackgroundImage = Properties.Resources.icons8_documents_100;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(81, 77);
            button1.TabIndex = 2;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(474, 462);
            dataGridView1.TabIndex = 4;
            // 
            // FormMain_CNM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 613);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxControl_CNM);
            Name = "FormMain_CNM";
            Text = "Спринт 7 | Проект | Вариант 2 | Чугин Н.М.";
            groupBoxControl_CNM.ResumeLayout(false);
            groupBoxControl_CNM.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxControl_CNM;
        private Button buttonOpenFile_CNM;
        private Button buttonSaveFile_CNM;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
