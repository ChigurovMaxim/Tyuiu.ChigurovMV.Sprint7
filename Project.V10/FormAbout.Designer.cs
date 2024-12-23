namespace Project.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAuthor_CMV = new PictureBox();
            buttonOK_CMV = new Button();
            textBoxHelp_CMV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_CMV).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAuthor_CMV
            // 
            pictureBoxAuthor_CMV.Image = (Image)resources.GetObject("pictureBoxAuthor_CMV.Image");
            pictureBoxAuthor_CMV.Location = new Point(12, 12);
            pictureBoxAuthor_CMV.Name = "pictureBoxAuthor_CMV";
            pictureBoxAuthor_CMV.Size = new Size(111, 151);
            pictureBoxAuthor_CMV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAuthor_CMV.TabIndex = 5;
            pictureBoxAuthor_CMV.TabStop = false;
            // 
            // buttonOK_CMV
            // 
            buttonOK_CMV.Cursor = Cursors.Hand;
            buttonOK_CMV.Location = new Point(354, 180);
            buttonOK_CMV.Name = "buttonOK_CMV";
            buttonOK_CMV.Size = new Size(75, 23);
            buttonOK_CMV.TabIndex = 4;
            buttonOK_CMV.Text = "Ок";
            buttonOK_CMV.UseVisualStyleBackColor = true;
            buttonOK_CMV.Click += buttonOk_Click;
            // 
            // textBoxHelp_CMV
            // 
            textBoxHelp_CMV.Location = new Point(129, 12);
            textBoxHelp_CMV.Multiline = true;
            textBoxHelp_CMV.Name = "textBoxHelp_CMV";
            textBoxHelp_CMV.ReadOnly = true;
            textBoxHelp_CMV.Size = new Size(313, 151);
            textBoxHelp_CMV.TabIndex = 3;
            textBoxHelp_CMV.TabStop = false;
            textBoxHelp_CMV.Text = resources.GetString("textBoxHelp_CMV.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 232);
            Controls.Add(pictureBoxAuthor_CMV);
            Controls.Add(buttonOK_CMV);
            Controls.Add(textBoxHelp_CMV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(479, 271);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_CMV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAuthor_CMV;
        private Button buttonOK_CMV;
        private TextBox textBoxHelp_CMV;
    }
}