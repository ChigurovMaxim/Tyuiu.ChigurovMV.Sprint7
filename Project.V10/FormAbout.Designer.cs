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
            pictureBoxAuthor_CMV.Location = new Point(14, 16);
            pictureBoxAuthor_CMV.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAuthor_CMV.Name = "pictureBoxAuthor_CMV";
            pictureBoxAuthor_CMV.Size = new Size(127, 201);
            pictureBoxAuthor_CMV.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAuthor_CMV.TabIndex = 5;
            pictureBoxAuthor_CMV.TabStop = false;
            // 
            // buttonOK_CMV
            // 
            buttonOK_CMV.Cursor = Cursors.Hand;
            buttonOK_CMV.Location = new Point(405, 276);
            buttonOK_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonOK_CMV.Name = "buttonOK_CMV";
            buttonOK_CMV.Size = new Size(86, 31);
            buttonOK_CMV.TabIndex = 4;
            buttonOK_CMV.Text = "Ок";
            buttonOK_CMV.UseVisualStyleBackColor = true;
            buttonOK_CMV.Click += buttonOk_Click;
            // 
            // textBoxHelp_CMV
            // 
            textBoxHelp_CMV.Location = new Point(147, 16);
            textBoxHelp_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxHelp_CMV.Multiline = true;
            textBoxHelp_CMV.Name = "textBoxHelp_CMV";
            textBoxHelp_CMV.ReadOnly = true;
            textBoxHelp_CMV.Size = new Size(357, 252);
            textBoxHelp_CMV.TabIndex = 3;
            textBoxHelp_CMV.TabStop = false;
            textBoxHelp_CMV.Text = resources.GetString("textBoxHelp_CMV.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 346);
            Controls.Add(pictureBoxAuthor_CMV);
            Controls.Add(buttonOK_CMV);
            Controls.Add(textBoxHelp_CMV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(545, 346);
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