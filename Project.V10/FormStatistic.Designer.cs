namespace Project.V10
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxOrdersStatistic_CMV = new GroupBox();
            labelOrdersCount_CMV = new Label();
            labelDelivered_CMV = new Label();
            labelInTransit_CMV = new Label();
            labelAverageOrderValue_CMV = new Label();
            labelMinOrderValue_CMV = new Label();
            labelMaxOrderValue_CMV = new Label();
            labelMostPopularDateOfOrder_CMV = new Label();
            labelMostPopularUserID_CMV = new Label();
            groupBoxProduct_CMV = new GroupBox();
            labelAverageProductPrice_CMV = new Label();
            labelMinProductPrice_CMV = new Label();
            labelMaxProductPrice_CMV = new Label();
            labelMaxProductCount_CMV = new Label();
            labelMostPopularProduct_CMV = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOrdersStatistic_CMV.SuspendLayout();
            groupBoxProduct_CMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOrdersStatistic_CMV
            // 
            groupBoxOrdersStatistic_CMV.Controls.Add(labelOrdersCount_CMV);
            groupBoxOrdersStatistic_CMV.Controls.Add(labelDelivered_CMV);
            groupBoxOrdersStatistic_CMV.Controls.Add(labelInTransit_CMV);
            groupBoxOrdersStatistic_CMV.Controls.Add(labelAverageOrderValue_CMV);
            groupBoxOrdersStatistic_CMV.Controls.Add(labelMinOrderValue_CMV);
            groupBoxOrdersStatistic_CMV.Controls.Add(labelMaxOrderValue_CMV);
            groupBoxOrdersStatistic_CMV.Controls.Add(labelMostPopularDateOfOrder_CMV);
            groupBoxOrdersStatistic_CMV.Controls.Add(labelMostPopularUserID_CMV);
            groupBoxOrdersStatistic_CMV.Location = new Point(12, 12);
            groupBoxOrdersStatistic_CMV.Name = "groupBoxOrdersStatistic_CMV";
            groupBoxOrdersStatistic_CMV.Size = new Size(354, 228);
            groupBoxOrdersStatistic_CMV.TabIndex = 0;
            groupBoxOrdersStatistic_CMV.TabStop = false;
            groupBoxOrdersStatistic_CMV.Text = "Заказы";
            // 
            // labelOrdersCount_CMV
            // 
            labelOrdersCount_CMV.AutoSize = true;
            labelOrdersCount_CMV.Location = new Point(6, 193);
            labelOrdersCount_CMV.Name = "labelOrdersCount_CMV";
            labelOrdersCount_CMV.Size = new Size(86, 15);
            labelOrdersCount_CMV.TabIndex = 0;
            labelOrdersCount_CMV.Text = "Заказов всего:";
            // 
            // labelDelivered_CMV
            // 
            labelDelivered_CMV.AutoSize = true;
            labelDelivered_CMV.Location = new Point(6, 176);
            labelDelivered_CMV.Name = "labelDelivered_CMV";
            labelDelivered_CMV.Size = new Size(119, 15);
            labelDelivered_CMV.TabIndex = 0;
            labelDelivered_CMV.Text = "Заказов доставлено:";
            // 
            // labelInTransit_CMV
            // 
            labelInTransit_CMV.AutoSize = true;
            labelInTransit_CMV.Location = new Point(6, 159);
            labelInTransit_CMV.Name = "labelInTransit_CMV";
            labelInTransit_CMV.Size = new Size(90, 15);
            labelInTransit_CMV.TabIndex = 0;
            labelInTransit_CMV.Text = "Заказов в пути:";
            // 
            // labelAverageOrderValue_CMV
            // 
            labelAverageOrderValue_CMV.AutoSize = true;
            labelAverageOrderValue_CMV.Location = new Point(6, 118);
            labelAverageOrderValue_CMV.Name = "labelAverageOrderValue_CMV";
            labelAverageOrderValue_CMV.Size = new Size(154, 15);
            labelAverageOrderValue_CMV.TabIndex = 0;
            labelAverageOrderValue_CMV.Text = "Средняя стоимость заказа:";
            // 
            // labelMinOrderValue_CMV
            // 
            labelMinOrderValue_CMV.AutoSize = true;
            labelMinOrderValue_CMV.Location = new Point(6, 100);
            labelMinOrderValue_CMV.Name = "labelMinOrderValue_CMV";
            labelMinOrderValue_CMV.Size = new Size(187, 15);
            labelMinOrderValue_CMV.TabIndex = 0;
            labelMinOrderValue_CMV.Text = "Минимальная стоимость заказа:";
            // 
            // labelMaxOrderValue_CMV
            // 
            labelMaxOrderValue_CMV.AutoSize = true;
            labelMaxOrderValue_CMV.Location = new Point(6, 82);
            labelMaxOrderValue_CMV.Name = "labelMaxOrderValue_CMV";
            labelMaxOrderValue_CMV.Size = new Size(191, 15);
            labelMaxOrderValue_CMV.TabIndex = 0;
            labelMaxOrderValue_CMV.Text = "Максимальная стоимость заказа:";
            // 
            // labelMostPopularDateOfOrder_CMV
            // 
            labelMostPopularDateOfOrder_CMV.AutoSize = true;
            labelMostPopularDateOfOrder_CMV.Location = new Point(6, 46);
            labelMostPopularDateOfOrder_CMV.Name = "labelMostPopularDateOfOrder_CMV";
            labelMostPopularDateOfOrder_CMV.Size = new Size(184, 15);
            labelMostPopularDateOfOrder_CMV.TabIndex = 0;
            labelMostPopularDateOfOrder_CMV.Text = "Самая популярная дата заказов:";
            // 
            // labelMostPopularUserID_CMV
            // 
            labelMostPopularUserID_CMV.AutoSize = true;
            labelMostPopularUserID_CMV.Location = new Point(6, 28);
            labelMostPopularUserID_CMV.Name = "labelMostPopularUserID_CMV";
            labelMostPopularUserID_CMV.Size = new Size(213, 15);
            labelMostPopularUserID_CMV.TabIndex = 0;
            labelMostPopularUserID_CMV.Text = "Частовстречающийся пользователь: ";
            // 
            // groupBoxProduct_CMV
            // 
            groupBoxProduct_CMV.Controls.Add(labelAverageProductPrice_CMV);
            groupBoxProduct_CMV.Controls.Add(labelMinProductPrice_CMV);
            groupBoxProduct_CMV.Controls.Add(labelMaxProductPrice_CMV);
            groupBoxProduct_CMV.Controls.Add(labelMaxProductCount_CMV);
            groupBoxProduct_CMV.Controls.Add(labelMostPopularProduct_CMV);
            groupBoxProduct_CMV.Location = new Point(12, 246);
            groupBoxProduct_CMV.Name = "groupBoxProduct_CMV";
            groupBoxProduct_CMV.Size = new Size(354, 151);
            groupBoxProduct_CMV.TabIndex = 0;
            groupBoxProduct_CMV.TabStop = false;
            groupBoxProduct_CMV.Text = "Товары";
            // 
            // labelAverageProductPrice_CMV
            // 
            labelAverageProductPrice_CMV.AutoSize = true;
            labelAverageProductPrice_CMV.Location = new Point(6, 120);
            labelAverageProductPrice_CMV.Name = "labelAverageProductPrice_CMV";
            labelAverageProductPrice_CMV.Size = new Size(157, 15);
            labelAverageProductPrice_CMV.TabIndex = 0;
            labelAverageProductPrice_CMV.Text = "Средняя стоимость товара:";
            // 
            // labelMinProductPrice_CMV
            // 
            labelMinProductPrice_CMV.AutoSize = true;
            labelMinProductPrice_CMV.Location = new Point(6, 103);
            labelMinProductPrice_CMV.Name = "labelMinProductPrice_CMV";
            labelMinProductPrice_CMV.Size = new Size(190, 15);
            labelMinProductPrice_CMV.TabIndex = 0;
            labelMinProductPrice_CMV.Text = "Минимальная стоимость товара:";
            // 
            // labelMaxProductPrice_CMV
            // 
            labelMaxProductPrice_CMV.AutoSize = true;
            labelMaxProductPrice_CMV.Location = new Point(6, 86);
            labelMaxProductPrice_CMV.Name = "labelMaxProductPrice_CMV";
            labelMaxProductPrice_CMV.Size = new Size(194, 15);
            labelMaxProductPrice_CMV.TabIndex = 0;
            labelMaxProductPrice_CMV.Text = "Максимальная стоимость товара:";
            // 
            // labelMaxProductCount_CMV
            // 
            labelMaxProductCount_CMV.AutoSize = true;
            labelMaxProductCount_CMV.Location = new Point(6, 55);
            labelMaxProductCount_CMV.Name = "labelMaxProductCount_CMV";
            labelMaxProductCount_CMV.Size = new Size(201, 15);
            labelMaxProductCount_CMV.TabIndex = 0;
            labelMaxProductCount_CMV.Text = "Максимальное количество товара:";
            // 
            // labelMostPopularProduct_CMV
            // 
            labelMostPopularProduct_CMV.AutoSize = true;
            labelMostPopularProduct_CMV.Location = new Point(6, 28);
            labelMostPopularProduct_CMV.Name = "labelMostPopularProduct_CMV";
            labelMostPopularProduct_CMV.Size = new Size(156, 15);
            labelMostPopularProduct_CMV.TabIndex = 0;
            labelMostPopularProduct_CMV.Text = "Самый популярный товар:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(410, 16);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(434, 381);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 489);
            Controls.Add(chart1);
            Controls.Add(groupBoxProduct_CMV);
            Controls.Add(groupBoxOrdersStatistic_CMV);
            Name = "FormStatistic";
            Text = "Статистика";
            Load += FormStatistics_Load;
            groupBoxOrdersStatistic_CMV.ResumeLayout(false);
            groupBoxOrdersStatistic_CMV.PerformLayout();
            groupBoxProduct_CMV.ResumeLayout(false);
            groupBoxProduct_CMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOrdersStatistic_CMV;
        private Label labelMostPopularDateOfOrder_CMV;
        private Label labelMostPopularUserID_CMV;
        private Label labelMaxOrderValue_CMV;
        private Label labelMinOrderValue_CMV;
        private Label labelAverageOrderValue_CMV;
        private Label labelOrdersCount_CMV;
        private Label labelDelivered_CMV;
        private Label labelInTransit_CMV;
        private GroupBox groupBoxProduct_CMV;
        private Label labelAverageProductPrice_CMV;
        private Label labelMinProductPrice_CMV;
        private Label labelMaxProductPrice_CMV;
        private Label labelMaxProductCount_CMV;
        private Label labelMostPopularProduct_CMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}