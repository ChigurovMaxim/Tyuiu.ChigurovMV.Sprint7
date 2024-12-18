namespace Project.V10
{
    partial class FormMain
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
            panelTop_CMV = new Panel();
            panelRight_CMV = new Panel();
            panelFill_CMV = new Panel();
            dataGridViewTable_CMV = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderValue = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductCount = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            buttonOpenFile_CMV = new Button();
            openFileDialogTask_CMV = new OpenFileDialog();
            toolTipTask_CMV = new ToolTip(components);
            saveFileDialogTask_CMV = new SaveFileDialog();
            panelTop_CMV.SuspendLayout();
            panelFill_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_CMV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_CMV
            // 
            panelTop_CMV.Controls.Add(buttonOpenFile_CMV);
            panelTop_CMV.Dock = DockStyle.Top;
            panelTop_CMV.Location = new Point(0, 0);
            panelTop_CMV.Name = "panelTop_CMV";
            panelTop_CMV.Size = new Size(1097, 91);
            panelTop_CMV.TabIndex = 0;
            // 
            // panelRight_CMV
            // 
            panelRight_CMV.Dock = DockStyle.Right;
            panelRight_CMV.Location = new Point(790, 91);
            panelRight_CMV.Name = "panelRight_CMV";
            panelRight_CMV.Size = new Size(307, 395);
            panelRight_CMV.TabIndex = 1;
            // 
            // panelFill_CMV
            // 
            panelFill_CMV.Controls.Add(dataGridViewTable_CMV);
            panelFill_CMV.Dock = DockStyle.Fill;
            panelFill_CMV.Location = new Point(0, 91);
            panelFill_CMV.Name = "panelFill_CMV";
            panelFill_CMV.Size = new Size(790, 395);
            panelFill_CMV.TabIndex = 2;
            // 
            // dataGridViewTable_CMV
            // 
            dataGridViewTable_CMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_CMV.Columns.AddRange(new DataGridViewColumn[] { OrderID, UserID, OrderDate, OrderValue, ProductName, ProductCount, ProductPrice });
            dataGridViewTable_CMV.Dock = DockStyle.Fill;
            dataGridViewTable_CMV.Location = new Point(0, 0);
            dataGridViewTable_CMV.Name = "dataGridViewTable_CMV";
            dataGridViewTable_CMV.RowHeadersVisible = false;
            dataGridViewTable_CMV.RowHeadersWidth = 51;
            dataGridViewTable_CMV.Size = new Size(790, 395);
            dataGridViewTable_CMV.TabIndex = 0;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "Номер заказа";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.Width = 75;
            // 
            // UserID
            // 
            UserID.HeaderText = "ID пользователя";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.Width = 125;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "Дата исполнения";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 125;
            // 
            // OrderValue
            // 
            OrderValue.HeaderText = "Стоимость заказа";
            OrderValue.MinimumWidth = 6;
            OrderValue.Name = "OrderValue";
            OrderValue.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Название товара";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // ProductCount
            // 
            ProductCount.HeaderText = "Количество";
            ProductCount.MinimumWidth = 6;
            ProductCount.Name = "ProductCount";
            ProductCount.Width = 125;
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Стоимость заказа";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Width = 125;
            // 
            // buttonOpenFile_CMV
            // 
            buttonOpenFile_CMV.Image = Properties.Resources.database_go;
            buttonOpenFile_CMV.Location = new Point(24, 12);
            buttonOpenFile_CMV.Name = "buttonOpenFile_CMV";
            buttonOpenFile_CMV.Size = new Size(63, 60);
            buttonOpenFile_CMV.TabIndex = 0;
            buttonOpenFile_CMV.UseVisualStyleBackColor = true;
            buttonOpenFile_CMV.Click += buttonOpenFile_CMV_Click;
            // 
            // openFileDialogTask_CMV
            // 
            openFileDialogTask_CMV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 486);
            Controls.Add(panelFill_CMV);
            Controls.Add(panelRight_CMV);
            Controls.Add(panelTop_CMV);
            Name = "FormMain";
            Text = "Form1";
            panelTop_CMV.ResumeLayout(false);
            panelFill_CMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_CMV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_CMV;
        private Panel panelRight_CMV;
        private Panel panelFill_CMV;
        private DataGridView dataGridViewTable_CMV;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderValue;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ProductPrice;
        private Button buttonOpenFile_CMV;
        private OpenFileDialog openFileDialogTask_CMV;
        private ToolTip toolTipTask_CMV;
        private SaveFileDialog saveFileDialogTask_CMV;
    }
}
