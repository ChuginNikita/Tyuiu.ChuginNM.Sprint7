namespace Tyuiu.ChuginNM.Sprint7.Project.V2
{
    partial class FormAbout_CNM
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
            groupBoxAbout_CNM = new GroupBox();
            textBoxAbout_CNM = new TextBox();
            textBoxFishBox_CNM = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxAbout_CNM.SuspendLayout();
            textBoxFishBox_CNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAbout_CNM
            // 
            groupBoxAbout_CNM.Controls.Add(textBoxAbout_CNM);
            groupBoxAbout_CNM.Location = new Point(241, 12);
            groupBoxAbout_CNM.Name = "groupBoxAbout_CNM";
            groupBoxAbout_CNM.Size = new Size(206, 110);
            groupBoxAbout_CNM.TabIndex = 1;
            groupBoxAbout_CNM.TabStop = false;
            groupBoxAbout_CNM.Text = "Справка";
            // 
            // textBoxAbout_CNM
            // 
            textBoxAbout_CNM.Location = new Point(6, 22);
            textBoxAbout_CNM.Multiline = true;
            textBoxAbout_CNM.Name = "textBoxAbout_CNM";
            textBoxAbout_CNM.ReadOnly = true;
            textBoxAbout_CNM.Size = new Size(188, 82);
            textBoxAbout_CNM.TabIndex = 0;
            textBoxAbout_CNM.Text = "Программу написал Чугин Никита Максимович, студент группы АСОиУб-25-1, в рамках Курсов по программированию C#.";
            // 
            // textBoxFishBox_CNM
            // 
            textBoxFishBox_CNM.Controls.Add(pictureBox1);
            textBoxFishBox_CNM.Location = new Point(12, 12);
            textBoxFishBox_CNM.Name = "textBoxFishBox_CNM";
            textBoxFishBox_CNM.Size = new Size(223, 100);
            textBoxFishBox_CNM.TabIndex = 2;
            textBoxFishBox_CNM.TabStop = false;
            textBoxFishBox_CNM.Text = "unanchored compressed fish gif";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.spinning_fish;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAbout_CNM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 134);
            Controls.Add(textBoxFishBox_CNM);
            Controls.Add(groupBoxAbout_CNM);
            MaximumSize = new Size(475, 173);
            MinimumSize = new Size(475, 173);
            Name = "FormAbout_CNM";
            Text = "О программе";
            groupBoxAbout_CNM.ResumeLayout(false);
            groupBoxAbout_CNM.PerformLayout();
            textBoxFishBox_CNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxAbout_CNM;
        private TextBox textBoxAbout_CNM;
        private GroupBox textBoxFishBox_CNM;
        private PictureBox pictureBox1;
    }
}