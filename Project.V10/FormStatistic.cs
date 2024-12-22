﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V10
{
    public partial class FormStatistic : Form
    {
        private static DataGridView mainFormDataGrid;
        public FormStatistic(DataGridView dataGrid)
        {
            mainFormDataGrid = dataGrid;
            InitializeComponent();
        }

        //Считывание ячеек с таблицы
        private static int[] GetIntCellsFromColumn(int column)
        {
            int[] columnArray = new int[mainFormDataGrid.RowCount];
            for (int i = 0; i < columnArray.Length; i++)
            {
                columnArray[i] = Convert.ToInt32(mainFormDataGrid.Rows[i].Cells[column].Value);
            }
            return columnArray;
        }

        private static string[] GetStringCellsFromColumn(int column)
        {
            string[] columnArray = new string[mainFormDataGrid.RowCount];
            for (int i = 0; i < columnArray.Length; i++)
            {
                columnArray[i] = Convert.ToString(mainFormDataGrid.Rows[i].Cells[column].Value);
            }
            return columnArray;
        }

        //Нахождение самых повторяющихся элементов
        private static string GetMostRepeatedString(int column)
        {
            var query = GetStringCellsFromColumn(column).GroupBy(x => x)
                                                             .Where(item => item.Count() > 1)
                                                             .Select(item => new { Number = item.Count(), Name = item.Key })
                                                             .ToArray();
            string repetition = "";
            foreach (var item in query)
            {
                if (item.Number == query.Max(x => x.Number))
                {
                    repetition = item.Name;
                }
            }
            return repetition;
        }

        public static double GetAverageStatFromColumn(int column) => Math.Round(GetIntCellsFromColumn(column).Average(), 3);
        public static int GetMaxStatFromColumn(int column) => GetIntCellsFromColumn(column).Max();
        public static int GetMinStatFromColumn(int column) => GetIntCellsFromColumn(column).Min();
        public static int GetCountStatFromColumn(int column) => GetIntCellsFromColumn(column).Count();

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            int InTransitCount = 0;
            foreach (string i in GetStringCellsFromColumn(3))
            {
                if (i == "В ПУТИ")
                {
                    InTransitCount++;
                }
            }
            int DeliveredCount = 0;
            foreach (string i in GetStringCellsFromColumn(3))
            {
                if (i == "ДОСТАВЛЕН")
                {
                    DeliveredCount++;
                }
            }
            labelMostPopularUserID_CMV.Text += " " + GetMostRepeatedString(1);
            labelMostPopularDateOfOrder_CMV.Text += " " + GetMostRepeatedString(2);
            labelMaxOrderValue_CMV.Text += " " + GetMaxStatFromColumn(4).ToString();
            labelMinOrderValue_CMV.Text += " " + GetMinStatFromColumn(4).ToString();
            labelAverageOrderValue_CMV.Text += " " + GetAverageStatFromColumn(4).ToString();
            labelInTransit_CMV.Text += " " + InTransitCount.ToString();
            labelDelivered_CMV.Text += " " + DeliveredCount.ToString();
            labelOrdersCount_CMV.Text += " " + mainFormDataGrid.RowCount.ToString();
            labelMostPopularProduct_CMV.Text += " " + GetMostRepeatedString(5);
            labelMaxProductCount_CMV.Text += " " + GetMaxStatFromColumn(6).ToString();
            labelMaxProductPrice_CMV.Text += " " + GetMaxStatFromColumn(7).ToString();
            labelMinProductPrice_CMV.Text += " " + GetMinStatFromColumn(7).ToString();
            labelAverageProductPrice_CMV.Text += " " + GetAverageStatFromColumn(7).ToString();
            /*labelAquaRowCount_NVI.Text += " " + RowsCount(Color.Aqua).ToString();
            labelRedRowsCount_NVI.Text += " " + RowsCount(Color.OrangeRed).ToString();
            this.chartMarkToSpeed_NVI.ChartAreas[0].AxisX.Title = "Скорость";
            this.chartMarkToSpeed_NVI.ChartAreas[0].AxisY.Title = "Расход топлива";
            this.chartMarkToSpeed_NVI.Series[0].Points.Clear();
            Array.Sort(GetIntCellsFromColumn(5));
            Array.Sort(GetIntCellsFromColumn(7));
            for (int i = 0; i < mainFormDataGrid.Rows.Count; i++)
            {
                this.chartMarkToSpeed_NVI.Series[0].Points.AddXY(GetIntCellsFromColumn(5)[i], GetIntCellsFromColumn(7)[i]);
            }*/
        }
    }
}