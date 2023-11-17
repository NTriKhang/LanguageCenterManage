using LanguageCenterManage.Services.Kmean.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Services.Kmean.Elbow
{
    public partial class ElbowForm : Form
    {
        //points is contain list of result of k-mean from k in range 1-7
        private List<List<DataPoint>> points;
        public int numberOfCluster { set; get; } = 0;
        public ElbowForm(List<List<DataPoint>> points)
        {
            this.points = points;
            InitializeComponent();
        }

        private void ElbowForm_Load(object sender, EventArgs e)
        {
            double maxDistortion = points.Max(pointSet => {
                double sumSquared = pointSet.Sum(point => Math.Pow(point.Distance, 2));
                return 1.0 / pointSet.Count * sumSquared;
            });

            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = 7;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            double maxYAxisValue = 100;
            objChart.AxisY.Maximum = maxYAxisValue;


            chart1.Series.Clear();

            string line = "Elbow";

            chart1.Series.Add(line);
            chart1.Series[line].Color = Color.Blue;
            chart1.Series[line].Legend = "Legend1";
            chart1.Series[line].ChartArea = "ChartArea1";
            chart1.Series[line].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            int res = 0;
            double distortionTmp = 0;
            int distorAccepted = 15;
            for (int k = 0; k < points.Count ;k++)
            {
                double distortion;
                double sumSquared = 0;
                for (int i = 0; i < points[k].Count; i++)
                {
                    sumSquared += Math.Pow(points[k][i].Distance, 2);
                }
                distortion = 1 / (double)points[k].Count * sumSquared;
                double normalizedDistortion = (distortion / maxDistortion) * maxYAxisValue;

                if(k == 0)
                    distortionTmp = normalizedDistortion;
                else if(k > 0 && res == 0)
                {
                    if (distortionTmp - normalizedDistortion < distorAccepted)
                        res = k;
                    else
                        distortionTmp = normalizedDistortion;
                }
                chart1.Series[line].Points.AddXY(k + 1, normalizedDistortion);
            }
            numberOfCluster = res;
            textBox1.Text = res.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numberOfCluster = Convert.ToInt32(textBox1.Text);
        }
    }

}
