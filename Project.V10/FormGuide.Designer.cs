﻿namespace Project.V10
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            textBoxGuide_CMV = new TextBox();
            buttonOk_CMV = new Button();
            SuspendLayout();
            // 
            // textBoxGuide_CMV
            // 
            textBoxGuide_CMV.Location = new Point(14, 16);
            textBoxGuide_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxGuide_CMV.Multiline = true;
            textBoxGuide_CMV.Name = "textBoxGuide_CMV";
            textBoxGuide_CMV.ReadOnly = true;
            textBoxGuide_CMV.Size = new Size(684, 584);
            textBoxGuide_CMV.TabIndex = 0;
            textBoxGuide_CMV.TabStop = false;
            textBoxGuide_CMV.Text = resources.GetString("textBoxGuide_CMV.Text");
            // 
            // buttonOk_CMV
            // 
            buttonOk_CMV.Location = new Point(609, 608);
            buttonOk_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonOk_CMV.Name = "buttonOk_CMV";
            buttonOk_CMV.Size = new Size(86, 31);
            buttonOk_CMV.TabIndex = 1;
            buttonOk_CMV.Text = "ОК";
            buttonOk_CMV.UseVisualStyleBackColor = true;
            buttonOk_CMV.Click += buttonOk_CMV_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 668);
            Controls.Add(buttonOk_CMV);
            Controls.Add(textBoxGuide_CMV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGuide_CMV;
        private Button buttonOk_CMV;
    }
}