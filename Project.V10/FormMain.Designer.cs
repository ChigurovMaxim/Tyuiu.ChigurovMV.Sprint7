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
            groupBoxRowsEdit_CMV = new GroupBox();
            checkBoxMarkRow_CMV = new CheckBox();
            buttonUnmarkDelete_CMV = new Button();
            buttonMarkDelete_CMV = new Button();
            buttonDeleteMarkedRow_CMV = new Button();
            buttonAddRow_CMV = new Button();
            groupBoxTable_CMV = new GroupBox();
            buttonOpenFile_CMV = new Button();
            buttonSaveFile_CMV = new Button();
            panelFill_CMV = new Panel();
            tabControlTable_CMV = new TabControl();
            tabPageReadOnly_CMV = new TabPage();
            dataGridViewReadOnly_CMV = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            OrderValue = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductCount = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            tabControlReadOnlySearch_CMV = new TabControl();
            tabPageReadOnlySearchOrderID_CMV = new TabPage();
            buttonReadOnlySearchOrderID_CMV = new Button();
            textBoxReadOnlySearchOrderID_CMV = new TextBox();
            tabPageReadOnlySearchUserID_CMV = new TabPage();
            buttonReadOnlySearchUserID_CMV = new Button();
            textBoxReadOnlySearchUserID_CMV = new TextBox();
            tabPageEdit_CMV = new TabPage();
            dataGridViewEdit_CMV = new DataGridView();
            OrderIDedit = new DataGridViewTextBoxColumn();
            UserIDedit = new DataGridViewTextBoxColumn();
            OrderDateEdit = new DataGridViewTextBoxColumn();
            OrderStatusEdit = new DataGridViewTextBoxColumn();
            OrderValueEdit = new DataGridViewTextBoxColumn();
            ProductNameEdit = new DataGridViewTextBoxColumn();
            ProductCountEdit = new DataGridViewTextBoxColumn();
            ProductPriceEdit = new DataGridViewTextBoxColumn();
            tabControlEditSearch_CMV = new TabControl();
            tabPageEditSearchOrderID_CMV = new TabPage();
            buttonEditSearchOrderID_CMV = new Button();
            textBoxEditSearchOrderID_CMV = new TextBox();
            tabPageEditSearchUserID_CMV = new TabPage();
            buttonEditSearchUserID_CMV = new Button();
            textBoxEditSearchUserID_CMV = new TextBox();
            openFileDialogTask_CMV = new OpenFileDialog();
            toolTipTask_CMV = new ToolTip(components);
            saveFileDialogTask_CMV = new SaveFileDialog();
            menuStrip_CMV = new MenuStrip();
            statsToolStripMenuItem_CMV = new ToolStripMenuItem();
            filterToolStripMenuItem_CMV = new ToolStripMenuItem();
            DeletedRowsToolStripMenuItem_CMV = new ToolStripMenuItem();
            AddedRowsToolStripMenuItem_CMV = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            guideToolStripMenuItem_CMV = new ToolStripMenuItem();
            infoToolStripMenuItem_CMV = new ToolStripMenuItem();
            panelTop_CMV.SuspendLayout();
            groupBoxRowsEdit_CMV.SuspendLayout();
            groupBoxTable_CMV.SuspendLayout();
            panelFill_CMV.SuspendLayout();
            tabControlTable_CMV.SuspendLayout();
            tabPageReadOnly_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadOnly_CMV).BeginInit();
            tabControlReadOnlySearch_CMV.SuspendLayout();
            tabPageReadOnlySearchOrderID_CMV.SuspendLayout();
            tabPageReadOnlySearchUserID_CMV.SuspendLayout();
            tabPageEdit_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdit_CMV).BeginInit();
            tabControlEditSearch_CMV.SuspendLayout();
            tabPageEditSearchOrderID_CMV.SuspendLayout();
            tabPageEditSearchUserID_CMV.SuspendLayout();
            menuStrip_CMV.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_CMV
            // 
            panelTop_CMV.Controls.Add(groupBoxRowsEdit_CMV);
            panelTop_CMV.Controls.Add(groupBoxTable_CMV);
            panelTop_CMV.Dock = DockStyle.Top;
            panelTop_CMV.Location = new Point(0, 30);
            panelTop_CMV.Name = "panelTop_CMV";
            panelTop_CMV.Size = new Size(1134, 139);
            panelTop_CMV.TabIndex = 0;
            // 
            // groupBoxRowsEdit_CMV
            // 
            groupBoxRowsEdit_CMV.Controls.Add(checkBoxMarkRow_CMV);
            groupBoxRowsEdit_CMV.Controls.Add(buttonUnmarkDelete_CMV);
            groupBoxRowsEdit_CMV.Controls.Add(buttonMarkDelete_CMV);
            groupBoxRowsEdit_CMV.Controls.Add(buttonDeleteMarkedRow_CMV);
            groupBoxRowsEdit_CMV.Controls.Add(buttonAddRow_CMV);
            groupBoxRowsEdit_CMV.Dock = DockStyle.Left;
            groupBoxRowsEdit_CMV.Location = new Point(229, 0);
            groupBoxRowsEdit_CMV.Margin = new Padding(3, 4, 3, 4);
            groupBoxRowsEdit_CMV.Name = "groupBoxRowsEdit_CMV";
            groupBoxRowsEdit_CMV.Padding = new Padding(3, 4, 3, 4);
            groupBoxRowsEdit_CMV.Size = new Size(504, 139);
            groupBoxRowsEdit_CMV.TabIndex = 2;
            groupBoxRowsEdit_CMV.TabStop = false;
            groupBoxRowsEdit_CMV.Text = "Строки";
            // 
            // checkBoxMarkRow_CMV
            // 
            checkBoxMarkRow_CMV.AutoSize = true;
            checkBoxMarkRow_CMV.Enabled = false;
            checkBoxMarkRow_CMV.Location = new Point(187, 44);
            checkBoxMarkRow_CMV.Margin = new Padding(3, 4, 3, 4);
            checkBoxMarkRow_CMV.Name = "checkBoxMarkRow_CMV";
            checkBoxMarkRow_CMV.Size = new Size(160, 24);
            checkBoxMarkRow_CMV.TabIndex = 4;
            checkBoxMarkRow_CMV.Text = "Выделение строки";
            checkBoxMarkRow_CMV.UseVisualStyleBackColor = true;
            checkBoxMarkRow_CMV.CheckedChanged += checkBoxMarkRow_CMV_Checked;
            // 
            // buttonUnmarkDelete_CMV
            // 
            buttonUnmarkDelete_CMV.Enabled = false;
            buttonUnmarkDelete_CMV.Image = Properties.Resources.bullet_green;
            buttonUnmarkDelete_CMV.Location = new Point(416, 44);
            buttonUnmarkDelete_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonUnmarkDelete_CMV.Name = "buttonUnmarkDelete_CMV";
            buttonUnmarkDelete_CMV.Size = new Size(58, 60);
            buttonUnmarkDelete_CMV.TabIndex = 3;
            toolTipTask_CMV.SetToolTip(buttonUnmarkDelete_CMV, "Снять пометку на удаление");
            buttonUnmarkDelete_CMV.UseVisualStyleBackColor = true;
            buttonUnmarkDelete_CMV.Click += buttonUnmarkDelete_CMV_Click;
            // 
            // buttonMarkDelete_CMV
            // 
            buttonMarkDelete_CMV.Enabled = false;
            buttonMarkDelete_CMV.Image = Properties.Resources.bullet_red;
            buttonMarkDelete_CMV.Location = new Point(351, 44);
            buttonMarkDelete_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonMarkDelete_CMV.Name = "buttonMarkDelete_CMV";
            buttonMarkDelete_CMV.Size = new Size(58, 60);
            buttonMarkDelete_CMV.TabIndex = 3;
            toolTipTask_CMV.SetToolTip(buttonMarkDelete_CMV, "Пометить строку на удаление");
            buttonMarkDelete_CMV.UseVisualStyleBackColor = true;
            buttonMarkDelete_CMV.Click += buttonMarkDelete_CMV_Click;
            // 
            // buttonDeleteMarkedRow_CMV
            // 
            buttonDeleteMarkedRow_CMV.Enabled = false;
            buttonDeleteMarkedRow_CMV.Image = Properties.Resources.cross;
            buttonDeleteMarkedRow_CMV.Location = new Point(106, 44);
            buttonDeleteMarkedRow_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteMarkedRow_CMV.Name = "buttonDeleteMarkedRow_CMV";
            buttonDeleteMarkedRow_CMV.Size = new Size(56, 60);
            buttonDeleteMarkedRow_CMV.TabIndex = 2;
            toolTipTask_CMV.SetToolTip(buttonDeleteMarkedRow_CMV, "Удалить помеченные строки");
            buttonDeleteMarkedRow_CMV.UseVisualStyleBackColor = true;
            buttonDeleteMarkedRow_CMV.Click += buttonDeleteMarkedRow_CMV_Click;
            // 
            // buttonAddRow_CMV
            // 
            buttonAddRow_CMV.Enabled = false;
            buttonAddRow_CMV.Image = Properties.Resources.add;
            buttonAddRow_CMV.Location = new Point(26, 44);
            buttonAddRow_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonAddRow_CMV.Name = "buttonAddRow_CMV";
            buttonAddRow_CMV.Size = new Size(56, 60);
            buttonAddRow_CMV.TabIndex = 0;
            toolTipTask_CMV.SetToolTip(buttonAddRow_CMV, "Добавить строку");
            buttonAddRow_CMV.UseVisualStyleBackColor = true;
            buttonAddRow_CMV.Click += buttonAdd_CMV_Click;
            // 
            // groupBoxTable_CMV
            // 
            groupBoxTable_CMV.Controls.Add(buttonOpenFile_CMV);
            groupBoxTable_CMV.Controls.Add(buttonSaveFile_CMV);
            groupBoxTable_CMV.Dock = DockStyle.Left;
            groupBoxTable_CMV.Location = new Point(0, 0);
            groupBoxTable_CMV.Margin = new Padding(3, 4, 3, 4);
            groupBoxTable_CMV.Name = "groupBoxTable_CMV";
            groupBoxTable_CMV.Padding = new Padding(3, 4, 3, 4);
            groupBoxTable_CMV.Size = new Size(229, 139);
            groupBoxTable_CMV.TabIndex = 1;
            groupBoxTable_CMV.TabStop = false;
            groupBoxTable_CMV.Text = "Таблица";
            // 
            // buttonOpenFile_CMV
            // 
            buttonOpenFile_CMV.Image = Properties.Resources.database_go;
            buttonOpenFile_CMV.Location = new Point(31, 44);
            buttonOpenFile_CMV.Name = "buttonOpenFile_CMV";
            buttonOpenFile_CMV.Size = new Size(63, 60);
            buttonOpenFile_CMV.TabIndex = 0;
            toolTipTask_CMV.SetToolTip(buttonOpenFile_CMV, "Открыть файл");
            buttonOpenFile_CMV.UseVisualStyleBackColor = true;
            buttonOpenFile_CMV.Click += buttonOpenFile_CMV_Click;
            // 
            // buttonSaveFile_CMV
            // 
            buttonSaveFile_CMV.Enabled = false;
            buttonSaveFile_CMV.Image = Properties.Resources.database_save;
            buttonSaveFile_CMV.Location = new Point(128, 44);
            buttonSaveFile_CMV.Name = "buttonSaveFile_CMV";
            buttonSaveFile_CMV.Size = new Size(63, 60);
            buttonSaveFile_CMV.TabIndex = 0;
            toolTipTask_CMV.SetToolTip(buttonSaveFile_CMV, "Сохранить файл");
            buttonSaveFile_CMV.UseVisualStyleBackColor = true;
            buttonSaveFile_CMV.Click += buttonSaveFile_CMV_Click;
            // 
            // panelFill_CMV
            // 
            panelFill_CMV.Controls.Add(tabControlTable_CMV);
            panelFill_CMV.Dock = DockStyle.Fill;
            panelFill_CMV.Location = new Point(0, 169);
            panelFill_CMV.Name = "panelFill_CMV";
            panelFill_CMV.Size = new Size(1134, 747);
            panelFill_CMV.TabIndex = 2;
            // 
            // tabControlTable_CMV
            // 
            tabControlTable_CMV.Controls.Add(tabPageReadOnly_CMV);
            tabControlTable_CMV.Controls.Add(tabPageEdit_CMV);
            tabControlTable_CMV.Dock = DockStyle.Fill;
            tabControlTable_CMV.Location = new Point(0, 0);
            tabControlTable_CMV.Margin = new Padding(3, 4, 3, 4);
            tabControlTable_CMV.Name = "tabControlTable_CMV";
            tabControlTable_CMV.Padding = new Point(6, 15);
            tabControlTable_CMV.SelectedIndex = 0;
            tabControlTable_CMV.Size = new Size(1134, 747);
            tabControlTable_CMV.TabIndex = 0;
            tabControlTable_CMV.SelectedIndexChanged += tabControlTable_CMV_SelectedIndexChanged;
            // 
            // tabPageReadOnly_CMV
            // 
            tabPageReadOnly_CMV.Controls.Add(dataGridViewReadOnly_CMV);
            tabPageReadOnly_CMV.Controls.Add(tabControlReadOnlySearch_CMV);
            tabPageReadOnly_CMV.Location = new Point(4, 53);
            tabPageReadOnly_CMV.Margin = new Padding(3, 4, 3, 4);
            tabPageReadOnly_CMV.Name = "tabPageReadOnly_CMV";
            tabPageReadOnly_CMV.Padding = new Padding(3, 4, 3, 4);
            tabPageReadOnly_CMV.Size = new Size(1126, 690);
            tabPageReadOnly_CMV.TabIndex = 0;
            tabPageReadOnly_CMV.Text = "Чтение";
            tabPageReadOnly_CMV.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReadOnly_CMV
            // 
            dataGridViewReadOnly_CMV.AllowUserToAddRows = false;
            dataGridViewReadOnly_CMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadOnly_CMV.Columns.AddRange(new DataGridViewColumn[] { OrderID, UserID, OrderDate, OrderStatus, OrderValue, ProductName, ProductCount, ProductPrice });
            dataGridViewReadOnly_CMV.Dock = DockStyle.Fill;
            dataGridViewReadOnly_CMV.Location = new Point(3, 83);
            dataGridViewReadOnly_CMV.Name = "dataGridViewReadOnly_CMV";
            dataGridViewReadOnly_CMV.ReadOnly = true;
            dataGridViewReadOnly_CMV.RowHeadersVisible = false;
            dataGridViewReadOnly_CMV.RowHeadersWidth = 51;
            dataGridViewReadOnly_CMV.Size = new Size(1120, 603);
            dataGridViewReadOnly_CMV.TabIndex = 0;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "Номер заказа";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Width = 75;
            // 
            // UserID
            // 
            UserID.HeaderText = "ID пользователя";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Width = 125;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "Дата исполнения";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 125;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Статус заказа";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 125;
            // 
            // OrderValue
            // 
            OrderValue.HeaderText = "Стоимость заказа (руб.)";
            OrderValue.MinimumWidth = 6;
            OrderValue.Name = "OrderValue";
            OrderValue.ReadOnly = true;
            OrderValue.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Название товара";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // ProductCount
            // 
            ProductCount.HeaderText = "Количество (шт.)";
            ProductCount.MinimumWidth = 6;
            ProductCount.Name = "ProductCount";
            ProductCount.ReadOnly = true;
            ProductCount.Width = 125;
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Стоимость товара (руб.)";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            ProductPrice.Width = 125;
            // 
            // tabControlReadOnlySearch_CMV
            // 
            tabControlReadOnlySearch_CMV.Controls.Add(tabPageReadOnlySearchOrderID_CMV);
            tabControlReadOnlySearch_CMV.Controls.Add(tabPageReadOnlySearchUserID_CMV);
            tabControlReadOnlySearch_CMV.Dock = DockStyle.Top;
            tabControlReadOnlySearch_CMV.Location = new Point(3, 4);
            tabControlReadOnlySearch_CMV.Margin = new Padding(3, 4, 3, 4);
            tabControlReadOnlySearch_CMV.Name = "tabControlReadOnlySearch_CMV";
            tabControlReadOnlySearch_CMV.SelectedIndex = 0;
            tabControlReadOnlySearch_CMV.Size = new Size(1120, 79);
            tabControlReadOnlySearch_CMV.TabIndex = 3;
            // 
            // tabPageReadOnlySearchOrderID_CMV
            // 
            tabPageReadOnlySearchOrderID_CMV.Controls.Add(buttonReadOnlySearchOrderID_CMV);
            tabPageReadOnlySearchOrderID_CMV.Controls.Add(textBoxReadOnlySearchOrderID_CMV);
            tabPageReadOnlySearchOrderID_CMV.Location = new Point(4, 29);
            tabPageReadOnlySearchOrderID_CMV.Margin = new Padding(3, 4, 3, 4);
            tabPageReadOnlySearchOrderID_CMV.Name = "tabPageReadOnlySearchOrderID_CMV";
            tabPageReadOnlySearchOrderID_CMV.Padding = new Padding(3, 4, 3, 4);
            tabPageReadOnlySearchOrderID_CMV.Size = new Size(1112, 46);
            tabPageReadOnlySearchOrderID_CMV.TabIndex = 0;
            tabPageReadOnlySearchOrderID_CMV.Text = "По номеру";
            tabPageReadOnlySearchOrderID_CMV.UseVisualStyleBackColor = true;
            // 
            // buttonReadOnlySearchOrderID_CMV
            // 
            buttonReadOnlySearchOrderID_CMV.BackgroundImage = Properties.Resources.zoom;
            buttonReadOnlySearchOrderID_CMV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonReadOnlySearchOrderID_CMV.Dock = DockStyle.Left;
            buttonReadOnlySearchOrderID_CMV.Location = new Point(225, 4);
            buttonReadOnlySearchOrderID_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonReadOnlySearchOrderID_CMV.Name = "buttonReadOnlySearchOrderID_CMV";
            buttonReadOnlySearchOrderID_CMV.Size = new Size(38, 38);
            buttonReadOnlySearchOrderID_CMV.TabIndex = 3;
            buttonReadOnlySearchOrderID_CMV.UseVisualStyleBackColor = true;
            buttonReadOnlySearchOrderID_CMV.Click += buttonReadOnlySearchOrderID_CMV_Click;
            // 
            // textBoxReadOnlySearchOrderID_CMV
            // 
            textBoxReadOnlySearchOrderID_CMV.Dock = DockStyle.Left;
            textBoxReadOnlySearchOrderID_CMV.Location = new Point(3, 4);
            textBoxReadOnlySearchOrderID_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxReadOnlySearchOrderID_CMV.Name = "textBoxReadOnlySearchOrderID_CMV";
            textBoxReadOnlySearchOrderID_CMV.PlaceholderText = "Поиск...";
            textBoxReadOnlySearchOrderID_CMV.Size = new Size(222, 27);
            textBoxReadOnlySearchOrderID_CMV.TabIndex = 0;
            // 
            // tabPageReadOnlySearchUserID_CMV
            // 
            tabPageReadOnlySearchUserID_CMV.Controls.Add(buttonReadOnlySearchUserID_CMV);
            tabPageReadOnlySearchUserID_CMV.Controls.Add(textBoxReadOnlySearchUserID_CMV);
            tabPageReadOnlySearchUserID_CMV.Location = new Point(4, 29);
            tabPageReadOnlySearchUserID_CMV.Margin = new Padding(3, 4, 3, 4);
            tabPageReadOnlySearchUserID_CMV.Name = "tabPageReadOnlySearchUserID_CMV";
            tabPageReadOnlySearchUserID_CMV.Padding = new Padding(3, 4, 3, 4);
            tabPageReadOnlySearchUserID_CMV.Size = new Size(1112, 46);
            tabPageReadOnlySearchUserID_CMV.TabIndex = 1;
            tabPageReadOnlySearchUserID_CMV.Text = "По ID пользователя";
            tabPageReadOnlySearchUserID_CMV.UseVisualStyleBackColor = true;
            // 
            // buttonReadOnlySearchUserID_CMV
            // 
            buttonReadOnlySearchUserID_CMV.BackgroundImage = Properties.Resources.zoom;
            buttonReadOnlySearchUserID_CMV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonReadOnlySearchUserID_CMV.Dock = DockStyle.Left;
            buttonReadOnlySearchUserID_CMV.Location = new Point(225, 4);
            buttonReadOnlySearchUserID_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonReadOnlySearchUserID_CMV.Name = "buttonReadOnlySearchUserID_CMV";
            buttonReadOnlySearchUserID_CMV.Size = new Size(38, 38);
            buttonReadOnlySearchUserID_CMV.TabIndex = 4;
            buttonReadOnlySearchUserID_CMV.UseVisualStyleBackColor = true;
            buttonReadOnlySearchUserID_CMV.Click += buttonReadOnlySearchUserID_CMV_Click;
            // 
            // textBoxReadOnlySearchUserID_CMV
            // 
            textBoxReadOnlySearchUserID_CMV.Dock = DockStyle.Left;
            textBoxReadOnlySearchUserID_CMV.Location = new Point(3, 4);
            textBoxReadOnlySearchUserID_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxReadOnlySearchUserID_CMV.Name = "textBoxReadOnlySearchUserID_CMV";
            textBoxReadOnlySearchUserID_CMV.PlaceholderText = "Поиск...";
            textBoxReadOnlySearchUserID_CMV.Size = new Size(222, 27);
            textBoxReadOnlySearchUserID_CMV.TabIndex = 1;
            // 
            // tabPageEdit_CMV
            // 
            tabPageEdit_CMV.Controls.Add(dataGridViewEdit_CMV);
            tabPageEdit_CMV.Controls.Add(tabControlEditSearch_CMV);
            tabPageEdit_CMV.Location = new Point(4, 53);
            tabPageEdit_CMV.Margin = new Padding(3, 4, 3, 4);
            tabPageEdit_CMV.Name = "tabPageEdit_CMV";
            tabPageEdit_CMV.Padding = new Padding(3, 4, 3, 4);
            tabPageEdit_CMV.Size = new Size(1126, 690);
            tabPageEdit_CMV.TabIndex = 1;
            tabPageEdit_CMV.Text = "Редактирование";
            tabPageEdit_CMV.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEdit_CMV
            // 
            dataGridViewEdit_CMV.AllowUserToAddRows = false;
            dataGridViewEdit_CMV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEdit_CMV.Columns.AddRange(new DataGridViewColumn[] { OrderIDedit, UserIDedit, OrderDateEdit, OrderStatusEdit, OrderValueEdit, ProductNameEdit, ProductCountEdit, ProductPriceEdit });
            dataGridViewEdit_CMV.Dock = DockStyle.Fill;
            dataGridViewEdit_CMV.Location = new Point(3, 83);
            dataGridViewEdit_CMV.Name = "dataGridViewEdit_CMV";
            dataGridViewEdit_CMV.RowHeadersVisible = false;
            dataGridViewEdit_CMV.RowHeadersWidth = 51;
            dataGridViewEdit_CMV.Size = new Size(1120, 603);
            dataGridViewEdit_CMV.TabIndex = 1;
            dataGridViewEdit_CMV.CellBeginEdit += dataGridViewEdit_CMV_CellBeginEdit;
            dataGridViewEdit_CMV.CellValidating += dataGridViewEdit_CMV_CellValidating;
            dataGridViewEdit_CMV.CellValueChanged += dataGridViewEdit_CMV_CellValueChanged;
            // 
            // OrderIDedit
            // 
            OrderIDedit.HeaderText = "Номер заказа";
            OrderIDedit.MinimumWidth = 6;
            OrderIDedit.Name = "OrderIDedit";
            OrderIDedit.Width = 75;
            // 
            // UserIDedit
            // 
            UserIDedit.HeaderText = "ID пользователя";
            UserIDedit.MinimumWidth = 6;
            UserIDedit.Name = "UserIDedit";
            UserIDedit.Width = 125;
            // 
            // OrderDateEdit
            // 
            OrderDateEdit.HeaderText = "Дата исполнения";
            OrderDateEdit.MinimumWidth = 6;
            OrderDateEdit.Name = "OrderDateEdit";
            OrderDateEdit.Width = 125;
            // 
            // OrderStatusEdit
            // 
            OrderStatusEdit.HeaderText = "Статус заказа";
            OrderStatusEdit.MinimumWidth = 6;
            OrderStatusEdit.Name = "OrderStatusEdit";
            OrderStatusEdit.Width = 125;
            // 
            // OrderValueEdit
            // 
            OrderValueEdit.HeaderText = "Стоимость заказа (руб.)";
            OrderValueEdit.MinimumWidth = 6;
            OrderValueEdit.Name = "OrderValueEdit";
            OrderValueEdit.Width = 125;
            // 
            // ProductNameEdit
            // 
            ProductNameEdit.HeaderText = "Название товара";
            ProductNameEdit.MinimumWidth = 6;
            ProductNameEdit.Name = "ProductNameEdit";
            ProductNameEdit.Width = 125;
            // 
            // ProductCountEdit
            // 
            ProductCountEdit.HeaderText = "Количество (шт.)";
            ProductCountEdit.MinimumWidth = 6;
            ProductCountEdit.Name = "ProductCountEdit";
            ProductCountEdit.Width = 125;
            // 
            // ProductPriceEdit
            // 
            ProductPriceEdit.HeaderText = "Стоимость товара (руб.)";
            ProductPriceEdit.MinimumWidth = 6;
            ProductPriceEdit.Name = "ProductPriceEdit";
            ProductPriceEdit.Width = 125;
            // 
            // tabControlEditSearch_CMV
            // 
            tabControlEditSearch_CMV.Controls.Add(tabPageEditSearchOrderID_CMV);
            tabControlEditSearch_CMV.Controls.Add(tabPageEditSearchUserID_CMV);
            tabControlEditSearch_CMV.Dock = DockStyle.Top;
            tabControlEditSearch_CMV.Location = new Point(3, 4);
            tabControlEditSearch_CMV.Margin = new Padding(3, 4, 3, 4);
            tabControlEditSearch_CMV.Name = "tabControlEditSearch_CMV";
            tabControlEditSearch_CMV.SelectedIndex = 0;
            tabControlEditSearch_CMV.Size = new Size(1120, 79);
            tabControlEditSearch_CMV.TabIndex = 2;
            // 
            // tabPageEditSearchOrderID_CMV
            // 
            tabPageEditSearchOrderID_CMV.Controls.Add(buttonEditSearchOrderID_CMV);
            tabPageEditSearchOrderID_CMV.Controls.Add(textBoxEditSearchOrderID_CMV);
            tabPageEditSearchOrderID_CMV.Location = new Point(4, 29);
            tabPageEditSearchOrderID_CMV.Margin = new Padding(3, 4, 3, 4);
            tabPageEditSearchOrderID_CMV.Name = "tabPageEditSearchOrderID_CMV";
            tabPageEditSearchOrderID_CMV.Padding = new Padding(3, 4, 3, 4);
            tabPageEditSearchOrderID_CMV.Size = new Size(1112, 46);
            tabPageEditSearchOrderID_CMV.TabIndex = 0;
            tabPageEditSearchOrderID_CMV.Text = "По номеру";
            tabPageEditSearchOrderID_CMV.UseVisualStyleBackColor = true;
            // 
            // buttonEditSearchOrderID_CMV
            // 
            buttonEditSearchOrderID_CMV.BackgroundImage = Properties.Resources.zoom;
            buttonEditSearchOrderID_CMV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditSearchOrderID_CMV.Dock = DockStyle.Left;
            buttonEditSearchOrderID_CMV.Location = new Point(225, 4);
            buttonEditSearchOrderID_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonEditSearchOrderID_CMV.Name = "buttonEditSearchOrderID_CMV";
            buttonEditSearchOrderID_CMV.Size = new Size(38, 38);
            buttonEditSearchOrderID_CMV.TabIndex = 4;
            buttonEditSearchOrderID_CMV.UseVisualStyleBackColor = true;
            buttonEditSearchOrderID_CMV.Click += buttonEditSearchOrderID_CMV_Click;
            // 
            // textBoxEditSearchOrderID_CMV
            // 
            textBoxEditSearchOrderID_CMV.Dock = DockStyle.Left;
            textBoxEditSearchOrderID_CMV.Location = new Point(3, 4);
            textBoxEditSearchOrderID_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxEditSearchOrderID_CMV.Name = "textBoxEditSearchOrderID_CMV";
            textBoxEditSearchOrderID_CMV.PlaceholderText = "Поиск...";
            textBoxEditSearchOrderID_CMV.Size = new Size(222, 27);
            textBoxEditSearchOrderID_CMV.TabIndex = 1;
            // 
            // tabPageEditSearchUserID_CMV
            // 
            tabPageEditSearchUserID_CMV.Controls.Add(buttonEditSearchUserID_CMV);
            tabPageEditSearchUserID_CMV.Controls.Add(textBoxEditSearchUserID_CMV);
            tabPageEditSearchUserID_CMV.Location = new Point(4, 29);
            tabPageEditSearchUserID_CMV.Margin = new Padding(3, 4, 3, 4);
            tabPageEditSearchUserID_CMV.Name = "tabPageEditSearchUserID_CMV";
            tabPageEditSearchUserID_CMV.Padding = new Padding(3, 4, 3, 4);
            tabPageEditSearchUserID_CMV.Size = new Size(1112, 46);
            tabPageEditSearchUserID_CMV.TabIndex = 1;
            tabPageEditSearchUserID_CMV.Text = "По ID пользователя";
            tabPageEditSearchUserID_CMV.UseVisualStyleBackColor = true;
            // 
            // buttonEditSearchUserID_CMV
            // 
            buttonEditSearchUserID_CMV.BackgroundImage = Properties.Resources.zoom;
            buttonEditSearchUserID_CMV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditSearchUserID_CMV.Dock = DockStyle.Left;
            buttonEditSearchUserID_CMV.Location = new Point(225, 4);
            buttonEditSearchUserID_CMV.Margin = new Padding(3, 4, 3, 4);
            buttonEditSearchUserID_CMV.Name = "buttonEditSearchUserID_CMV";
            buttonEditSearchUserID_CMV.Size = new Size(38, 38);
            buttonEditSearchUserID_CMV.TabIndex = 4;
            buttonEditSearchUserID_CMV.UseVisualStyleBackColor = true;
            buttonEditSearchUserID_CMV.Click += buttonEditSearchUserID_CMV_Click;
            // 
            // textBoxEditSearchUserID_CMV
            // 
            textBoxEditSearchUserID_CMV.Dock = DockStyle.Left;
            textBoxEditSearchUserID_CMV.Location = new Point(3, 4);
            textBoxEditSearchUserID_CMV.Margin = new Padding(3, 4, 3, 4);
            textBoxEditSearchUserID_CMV.Name = "textBoxEditSearchUserID_CMV";
            textBoxEditSearchUserID_CMV.PlaceholderText = "Поиск...";
            textBoxEditSearchUserID_CMV.Size = new Size(222, 27);
            textBoxEditSearchUserID_CMV.TabIndex = 1;
            // 
            // openFileDialogTask_CMV
            // 
            openFileDialogTask_CMV.FileName = "DataFile";
            // 
            // toolTipTask_CMV
            // 
            toolTipTask_CMV.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_CMV.ToolTipTitle = "Подсказка";
            // 
            // menuStrip_CMV
            // 
            menuStrip_CMV.ImageScalingSize = new Size(20, 20);
            menuStrip_CMV.Items.AddRange(new ToolStripItem[] { statsToolStripMenuItem_CMV, filterToolStripMenuItem_CMV, помощьToolStripMenuItem });
            menuStrip_CMV.Location = new Point(0, 0);
            menuStrip_CMV.Name = "menuStrip_CMV";
            menuStrip_CMV.Padding = new Padding(7, 3, 0, 3);
            menuStrip_CMV.Size = new Size(1134, 30);
            menuStrip_CMV.TabIndex = 1;
            menuStrip_CMV.Text = "menuStrip1";
            // 
            // statsToolStripMenuItem_CMV
            // 
            statsToolStripMenuItem_CMV.Name = "statsToolStripMenuItem_CMV";
            statsToolStripMenuItem_CMV.Size = new Size(98, 24);
            statsToolStripMenuItem_CMV.Text = "Статистика";
            statsToolStripMenuItem_CMV.Click += statsToolStripMenuItem_CMV_Click;
            // 
            // filterToolStripMenuItem_CMV
            // 
            filterToolStripMenuItem_CMV.DropDownItems.AddRange(new ToolStripItem[] { DeletedRowsToolStripMenuItem_CMV, AddedRowsToolStripMenuItem_CMV });
            filterToolStripMenuItem_CMV.Enabled = false;
            filterToolStripMenuItem_CMV.Name = "filterToolStripMenuItem_CMV";
            filterToolStripMenuItem_CMV.Size = new Size(74, 24);
            filterToolStripMenuItem_CMV.Text = "Фильтр";
            // 
            // DeletedRowsToolStripMenuItem_CMV
            // 
            DeletedRowsToolStripMenuItem_CMV.Checked = true;
            DeletedRowsToolStripMenuItem_CMV.CheckOnClick = true;
            DeletedRowsToolStripMenuItem_CMV.CheckState = CheckState.Checked;
            DeletedRowsToolStripMenuItem_CMV.Name = "DeletedRowsToolStripMenuItem_CMV";
            DeletedRowsToolStripMenuItem_CMV.Size = new Size(240, 26);
            DeletedRowsToolStripMenuItem_CMV.Text = "Удаленные строки";
            DeletedRowsToolStripMenuItem_CMV.CheckedChanged += DeletedRowsToolStripMenuItem_CMV_CheckedChanged;
            // 
            // AddedRowsToolStripMenuItem_CMV
            // 
            AddedRowsToolStripMenuItem_CMV.Checked = true;
            AddedRowsToolStripMenuItem_CMV.CheckOnClick = true;
            AddedRowsToolStripMenuItem_CMV.CheckState = CheckState.Checked;
            AddedRowsToolStripMenuItem_CMV.Name = "AddedRowsToolStripMenuItem_CMV";
            AddedRowsToolStripMenuItem_CMV.Size = new Size(240, 26);
            AddedRowsToolStripMenuItem_CMV.Text = "Добавленные строки";
            AddedRowsToolStripMenuItem_CMV.CheckedChanged += AddedRowsToolStripMenuItem_CMV_CheckedChanged;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guideToolStripMenuItem_CMV, infoToolStripMenuItem_CMV });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(83, 24);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // guideToolStripMenuItem_CMV
            // 
            guideToolStripMenuItem_CMV.Name = "guideToolStripMenuItem_CMV";
            guideToolStripMenuItem_CMV.Size = new Size(178, 26);
            guideToolStripMenuItem_CMV.Text = "Руководство";
            guideToolStripMenuItem_CMV.Click += руководствоToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem_CMV
            // 
            infoToolStripMenuItem_CMV.Name = "infoToolStripMenuItem_CMV";
            infoToolStripMenuItem_CMV.Size = new Size(178, 26);
            infoToolStripMenuItem_CMV.Text = "Справка";
            infoToolStripMenuItem_CMV.Click += infoToolStripMenuItem_CMV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 916);
            Controls.Add(panelFill_CMV);
            Controls.Add(panelTop_CMV);
            Controls.Add(menuStrip_CMV);
            MainMenuStrip = menuStrip_CMV;
            MinimumSize = new Size(1149, 952);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы";
            panelTop_CMV.ResumeLayout(false);
            groupBoxRowsEdit_CMV.ResumeLayout(false);
            groupBoxRowsEdit_CMV.PerformLayout();
            groupBoxTable_CMV.ResumeLayout(false);
            panelFill_CMV.ResumeLayout(false);
            tabControlTable_CMV.ResumeLayout(false);
            tabPageReadOnly_CMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadOnly_CMV).EndInit();
            tabControlReadOnlySearch_CMV.ResumeLayout(false);
            tabPageReadOnlySearchOrderID_CMV.ResumeLayout(false);
            tabPageReadOnlySearchOrderID_CMV.PerformLayout();
            tabPageReadOnlySearchUserID_CMV.ResumeLayout(false);
            tabPageReadOnlySearchUserID_CMV.PerformLayout();
            tabPageEdit_CMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdit_CMV).EndInit();
            tabControlEditSearch_CMV.ResumeLayout(false);
            tabPageEditSearchOrderID_CMV.ResumeLayout(false);
            tabPageEditSearchOrderID_CMV.PerformLayout();
            tabPageEditSearchUserID_CMV.ResumeLayout(false);
            tabPageEditSearchUserID_CMV.PerformLayout();
            menuStrip_CMV.ResumeLayout(false);
            menuStrip_CMV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop_CMV;
        private Panel panelFill_CMV;
        private DataGridView dataGridViewReadOnly_CMV;
        private Button buttonOpenFile_CMV;
        private OpenFileDialog openFileDialogTask_CMV;
        private ToolTip toolTipTask_CMV;
        private SaveFileDialog saveFileDialogTask_CMV;
        private TabControl tabControlTable_CMV;
        private TabPage tabPageReadOnly_CMV;
        private TabPage tabPageEdit_CMV;
        private DataGridView dataGridViewEdit_CMV;
        private Button buttonSaveFile_CMV;
        private TabControl tabControlEditSearch_CMV;
        private TabPage tabPageEditSearchOrderID_CMV;
        private TabPage tabPageEditSearchUserID_CMV;
        private TabControl tabControlReadOnlySearch_CMV;
        private TabPage tabPageReadOnlySearchOrderID_CMV;
        private TabPage tabPageReadOnlySearchUserID_CMV;
        private TextBox textBoxReadOnlySearchOrderID_CMV;
        private Button buttonReadOnlySearchOrderID_CMV;
        private TextBox textBoxReadOnlySearchUserID_CMV;
        private TextBox textBoxEditSearchOrderID_CMV;
        private TextBox textBoxEditSearchUserID_CMV;
        private Button buttonReadOnlySearchUserID_CMV;
        private Button buttonEditSearchOrderID_CMV;
        private Button buttonEditSearchUserID_CMV;
        private MenuStrip menuStrip_CMV;
        private ToolStripMenuItem statsToolStripMenuItem_CMV;
        private ToolStripMenuItem filterToolStripMenuItem_CMV;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private GroupBox groupBoxRowsEdit_CMV;
        private GroupBox groupBoxTable_CMV;
        private Button buttonAddRow_CMV;
        private Button buttonDeleteMarkedRow_CMV;
        private Button buttonMarkDelete_CMV;
        private Button buttonUnmarkDelete_CMV;
        private ToolStripMenuItem DeletedRowsToolStripMenuItem_CMV;
        private ToolStripMenuItem AddedRowsToolStripMenuItem_CMV;
        private CheckBox checkBoxMarkRow_CMV;
        private DataGridViewTextBoxColumn OrderIDedit;
        private DataGridViewTextBoxColumn UserIDedit;
        private DataGridViewTextBoxColumn OrderDateEdit;
        private DataGridViewTextBoxColumn OrderStatusEdit;
        private DataGridViewTextBoxColumn OrderValueEdit;
        private DataGridViewTextBoxColumn ProductNameEdit;
        private DataGridViewTextBoxColumn ProductCountEdit;
        private DataGridViewTextBoxColumn ProductPriceEdit;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn OrderValue;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ProductPrice;
        private ToolStripMenuItem guideToolStripMenuItem_CMV;
        private ToolStripMenuItem infoToolStripMenuItem_CMV;
    }
}
