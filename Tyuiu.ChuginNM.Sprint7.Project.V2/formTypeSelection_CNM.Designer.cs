namespace Tyuiu.ChuginNM.Sprint7.Project.V2
{
    partial class formTypeSelection_CNM
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
            radioButtonOwners_CNM = new RadioButton();
            radioButtonStores_CNM = new RadioButton();
            radioButtonSuppliers_CNM = new RadioButton();
            groupBox1 = new GroupBox();
            buttonSelectOK_CNM = new Button();
            buttonSelectCancel_CNM = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radioButtonOwners_CNM
            // 
            radioButtonOwners_CNM.AutoSize = true;
            radioButtonOwners_CNM.Location = new Point(6, 25);
            radioButtonOwners_CNM.Name = "radioButtonOwners_CNM";
            radioButtonOwners_CNM.Size = new Size(132, 19);
            radioButtonOwners_CNM.TabIndex = 0;
            radioButtonOwners_CNM.TabStop = true;
            radioButtonOwners_CNM.Text = "Список владельцев";
            radioButtonOwners_CNM.UseVisualStyleBackColor = true;
            radioButtonOwners_CNM.CheckedChanged += radioButtonOwners_CheckedChanged;
            // 
            // radioButtonStores_CNM
            // 
            radioButtonStores_CNM.AutoSize = true;
            radioButtonStores_CNM.Location = new Point(6, 50);
            radioButtonStores_CNM.Name = "radioButtonStores_CNM";
            radioButtonStores_CNM.Size = new Size(127, 19);
            radioButtonStores_CNM.TabIndex = 1;
            radioButtonStores_CNM.TabStop = true;
            radioButtonStores_CNM.Text = "Список магазинов";
            radioButtonStores_CNM.UseVisualStyleBackColor = true;
            radioButtonStores_CNM.CheckedChanged += radioButtonStores_CheckedChanged;
            // 
            // radioButtonSuppliers_CNM
            // 
            radioButtonSuppliers_CNM.AutoSize = true;
            radioButtonSuppliers_CNM.Location = new Point(6, 75);
            radioButtonSuppliers_CNM.Name = "radioButtonSuppliers_CNM";
            radioButtonSuppliers_CNM.Size = new Size(143, 19);
            radioButtonSuppliers_CNM.TabIndex = 2;
            radioButtonSuppliers_CNM.TabStop = true;
            radioButtonSuppliers_CNM.Text = "Список поставщиков";
            radioButtonSuppliers_CNM.UseVisualStyleBackColor = true;
            radioButtonSuppliers_CNM.CheckedChanged += radioButtonSuppliers_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonOwners_CNM);
            groupBox1.Controls.Add(radioButtonSuppliers_CNM);
            groupBox1.Controls.Add(radioButtonStores_CNM);
            groupBox1.Location = new Point(106, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите тип создаваемой таблицы";
            // 
            // buttonSelectOK_CNM
            // 
            buttonSelectOK_CNM.Location = new Point(172, 118);
            buttonSelectOK_CNM.Name = "buttonSelectOK_CNM";
            buttonSelectOK_CNM.Size = new Size(75, 26);
            buttonSelectOK_CNM.TabIndex = 4;
            buttonSelectOK_CNM.Text = "ОК";
            buttonSelectOK_CNM.UseVisualStyleBackColor = true;
            buttonSelectOK_CNM.Click += btnOK_Click;
            // 
            // buttonSelectCancel_CNM
            // 
            buttonSelectCancel_CNM.Location = new Point(253, 118);
            buttonSelectCancel_CNM.Name = "buttonSelectCancel_CNM";
            buttonSelectCancel_CNM.Size = new Size(75, 26);
            buttonSelectCancel_CNM.TabIndex = 5;
            buttonSelectCancel_CNM.Text = "Отмена";
            buttonSelectCancel_CNM.UseVisualStyleBackColor = true;
            buttonSelectCancel_CNM.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_spreadsheet_100;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // formTypeSelection_CNM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 153);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSelectCancel_CNM);
            Controls.Add(buttonSelectOK_CNM);
            Controls.Add(groupBox1);
            Name = "Выбор таблицы";
            Text = "Создание файла";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButtonOwners_CNM;
        private RadioButton radioButtonStores_CNM;
        private RadioButton radioButtonSuppliers_CNM;
        private GroupBox groupBox1;
        private Button buttonSelectOK_CNM;
        private Button buttonSelectCancel_CNM;
        private PictureBox pictureBox1;
    }
}