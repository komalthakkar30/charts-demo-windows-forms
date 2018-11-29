using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace thakkar_Assign6
{
    public partial class Form1 : Form
    {
        private Form2 f2;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetNewForm(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.FormClosed += new FormClosedEventHandler(BackButton_Click);
            
            // Back Button
            Button backButton = new Button();
            backButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            backButton.Location = new Point(12, 12);
            backButton.Name = "button1";
            backButton.Size = new Size(180, 47);
            backButton.Text = "Back to Portal";
            backButton.Click += new System.EventHandler(BackButton_Click);
            f2.Controls.Add(backButton);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            f2.Dispose();
            this.Show();
        }

        /******************    Stacked Bar Chart   *****************/
        private void StackedBarChart_Button_Click(object sender, EventArgs e)
        {
            GetNewForm(sender, e);
            
            Chart stackedBarChart = new Chart();
            stackedBarChart.Name = "stackedBarChart";
            stackedBarChart.Top = 100;
            stackedBarChart.Titles.Add(new Title("Stacked Bar Chart - Total Fruit Consumption"));
            stackedBarChart.Size = new Size(500, 500);

            ChartArea chartArea2 = new ChartArea();
            chartArea2.Name = "StackedBarChart_ChartArea";
            chartArea2.AxisX.Title = "Fruits";
            chartArea2.AxisY.Title = "Total Fruit Consumption";
            stackedBarChart.ChartAreas.Add(chartArea2);
            stackedBarChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            Legend legend1 = new Legend();
            stackedBarChart.Legends.Add(legend1);

            Series series1 = new Series();
            series1.ChartArea = "StackedBarChart_ChartArea";
            series1.Name = "John";
            series1.ChartType = SeriesChartType.StackedBar;
            stackedBarChart.Series.Add(series1);

            Series series2 = new Series();
            series2.ChartArea = "StackedBarChart_ChartArea";
            series2.Name = "Jane";
            series2.ChartType = SeriesChartType.StackedBar;
            stackedBarChart.Series.Add(series2);

            Series series3 = new Series();
            series3.ChartArea = "StackedBarChart_ChartArea";
            series3.Name = "Jack";
            series3.ChartType = SeriesChartType.StackedBar;
            stackedBarChart.Series.Add(series3);

            using (StreamReader sr = new StreamReader("..\\..\\data\\StackedBarData.txt"))
            {
                String line;
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] tokens = line.Split(',');

                    stackedBarChart.Series[0].Points.AddXY(tokens[0], tokens[1]);
                    stackedBarChart.Series[1].Points.AddXY(tokens[0], tokens[2]);
                    stackedBarChart.Series[2].Points.AddXY(tokens[0], tokens[3]);

                    line = sr.ReadLine();
                }
            }

            f2.Controls.Add(stackedBarChart);

            f2.Show();
            this.Hide();
        }

        /******************    Bubble Chart   *****************/
        private void BubbleChart_Button_Click(object sender, EventArgs e)
        {
            GetNewForm(sender, e);
            
            Chart bubbleChart = new Chart();
            bubbleChart.Name = "BubbleChart";
            bubbleChart.Top = 100;
            bubbleChart.Titles.Add(new Title("Bubble Bar Chart - Sugar and fat intake per country"));
            bubbleChart.Size = new Size(500, 500);

            ChartArea chartArea2 = new ChartArea();
            chartArea2.Name = "BubbleChart_ChartArea";
            chartArea2.AxisX.Title = "Safe fat intake 65g/day";
            chartArea2.AxisY.Title = "Daily sugar intake";
            bubbleChart.ChartAreas.Add(chartArea2);
            bubbleChart.ChartAreas[0].AxisX.Minimum = 65;
            bubbleChart.ChartAreas[0].AxisX.Maximum = 100;

            Series series1 = new Series();
            series1.ChartArea = "BubbleChart_ChartArea";
            series1.Name = "John";
            series1.ChartType = SeriesChartType.Bubble;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerColor = Color.Magenta;
            bubbleChart.Series.Add(series1);

            using (StreamReader sr = new StreamReader("..\\..\\data\\BubbleData.txt"))
            {
                String line;
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] tokens = line.Split(',');

                    bubbleChart.Series[0].Points.AddXY(Convert.ToDouble(tokens[0]), Convert.ToDouble(tokens[1]), Convert.ToDouble(tokens[2]));

                    line = sr.ReadLine();
                }
            }

            f2.Controls.Add(bubbleChart);

            f2.Show();
            this.Hide();
        }

        /******************    Pie Chart   *****************/
        private void PieChart_Button_Click(object sender, EventArgs e)
        {
            GetNewForm(sender, e);
            
            Chart pieChart = new Chart();
            pieChart.Name = "PieChart";
            pieChart.Top = 100;
            pieChart.Titles.Add(new Title("Pie Bar Chart - Daily Activities of John"));
            pieChart.Size = new Size(500, 500);

            ChartArea chartArea2 = new ChartArea();
            chartArea2.Name = "PieChart_ChartArea";
            chartArea2.AxisX.Title = "Fruits";
            chartArea2.AxisY.Title = "Total Fruit Consumption";
            pieChart.ChartAreas.Add(chartArea2);
            pieChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            Legend legend1 = new Legend();
            pieChart.Legends.Add(legend1);

            Series series1 = new Series();
            series1.ChartArea = "PieChart_ChartArea";
            series1.Name = "John";
            series1.ChartType = SeriesChartType.Pie;
            pieChart.Series.Add(series1);


            using (StreamReader sr = new StreamReader("..\\..\\data\\PieData.txt"))
            {
                String line;
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] tokens = line.Split(',');
                    pieChart.Series[0].Points.AddXY(tokens[0], tokens[1]);
                    line = sr.ReadLine();
                }
            }
            f2.Controls.Add(pieChart);

            f2.Show();
            this.Hide();

        }
        
        /******************    Line Chart   *****************/
        private void LineChart_Button_Click(object sender, EventArgs e)
        {
            GetNewForm(sender, e);
            
            Chart lineChart = new Chart();
            lineChart.Name = "lineChart";
            lineChart.Top = 100;
            lineChart.Titles.Add(new Title("Line Chart - Total Fruit Consumption"));
            lineChart.Size = new Size(500, 500);

            ChartArea chartArea2 = new ChartArea();
            chartArea2.Name = "LineChart_ChartArea";
            chartArea2.AxisX.Title = "Fruits";
            chartArea2.AxisY.Title = "Total Fruit Consumption";
            lineChart.ChartAreas.Add(chartArea2);
            lineChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            Legend legend1 = new Legend();
            lineChart.Legends.Add(legend1);

            Series series1 = new Series();
            series1.ChartArea = "LineChart_ChartArea";
            series1.Name = "John";
            series1.ChartType = SeriesChartType.Line;
            lineChart.Series.Add(series1);

            Series series2 = new Series();
            series2.ChartArea = "LineChart_ChartArea";
            series2.Name = "Jane";
            series2.ChartType = SeriesChartType.Line;
            lineChart.Series.Add(series2);

            Series series3 = new Series();
            series3.ChartArea = "LineChart_ChartArea";
            series3.Name = "Jack";
            series3.ChartType = SeriesChartType.Line;
            lineChart.Series.Add(series3);

            using (StreamReader sr = new StreamReader("..\\..\\data\\StackedBarData.txt"))
            {
                String line;
                line = sr.ReadLine();
                while (line != null)
                {
                    String[] tokens = line.Split(',');

                    lineChart.Series[0].Points.AddXY(tokens[0], tokens[1]);
                    lineChart.Series[1].Points.AddXY(tokens[0], tokens[2]);
                    lineChart.Series[2].Points.AddXY(tokens[0], tokens[3]);

                    line = sr.ReadLine();
                }
            }
            f2.Controls.Add(lineChart);

            f2.Show();
            this.Hide();
        }
    }
}
