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

namespace LanguageCenterManage.Services.Kmean.Silhouette
{
    public partial class SilhouetteForm : Form
    {
        //points is contain list of result of k-mean from k in range 1-7
        List<List<DataPoint>> ListPoints;
        public int numberOfCluster { set; get; } = 0;
        public SilhouetteForm(List<List<DataPoint>> ListPoints)
        {
            this.ListPoints = ListPoints;
            InitializeComponent();
        }

        private void SilhouetteForm_Load(object sender, EventArgs e)
        {
            int finalK = 0;
            double value = 0;
            for (int k = 1; k < ListPoints.Count; k++)
            {
                List<Silhouette> s = new List<Silhouette>();
                List<int> nonEmptyClusters = new List<int>();
                //caculate a and find the nearest cluster
                for (int i = 0; i < ListPoints[k].Count; i++)
                {
                    double a = 0;
                    int cnt = 0;
                    double minDistance = double.MaxValue;
                    int xCurrentCluster = ListPoints[k][i].Cluster.XPoint;
                    int yCurrentCluster = ListPoints[k][i].Cluster.YPoint;
                    Cluster nearestCluster = new Cluster(0, 0, 0, Color.Blue);

                    //calculate a and find nearest cluster
                    for (int j = 0; j < ListPoints[k].Count; j++)
                    {
                        if (ListPoints[k][i].Cluster.Number == ListPoints[k][j].Cluster.Number)
                        {
                            cnt++;
                            int xdis = (ListPoints[k][i].XPoint - ListPoints[k][j].XPoint);
                            int ydis = (ListPoints[k][i].YPoint - ListPoints[k][j].YPoint);
                            int tot = (xdis * xdis + ydis * ydis);
                            double distance = Math.Sqrt(tot);
                            a += distance;
                        }
                        else
                        {
                            int xNearCluster = ListPoints[k][j].Cluster.XPoint;
                            int yNearCluster = ListPoints[k][j].Cluster.YPoint;
                            int xdis = (xNearCluster - xCurrentCluster);
                            int ydis = (yNearCluster - yCurrentCluster);
                            int tot = (xdis * xdis + ydis * ydis);

                            double distance = Math.Sqrt(tot);
                            if (minDistance > distance)
                            {
                                minDistance = distance;
                                nearestCluster = ListPoints[k][j].Cluster;
                            }
                        }
                    }

                    a = a / cnt;
                    ListPoints[k][i].NearestNeighborCluster = nearestCluster;
                    s.Add(new Silhouette
                    {
                        a = a,
                        dataPointNumber = ListPoints[k][i].Number
                    });

                    if (cnt > 0 && !nonEmptyClusters.Contains(ListPoints[k][i].Cluster.Number))
                    {
                        nonEmptyClusters.Add(ListPoints[k][i].Cluster.Number);
                    }
                }
                //caculate b and s
                for (int i = 0; i < ListPoints[k].Count; i++)
                {
                    double b = 0;
                    int cnt = 0;
                    for (int j = 0; j < ListPoints[k].Count; j++)
                    {
                        if (ListPoints[k][i].NearestNeighborCluster.Number == ListPoints[k][j].Cluster.Number)
                        {
                            cnt++;
                            int xdis = (ListPoints[k][i].XPoint - ListPoints[k][j].XPoint);
                            int ydis = (ListPoints[k][i].YPoint - ListPoints[k][j].YPoint);
                            int tot = (xdis * xdis + ydis * ydis);
                            double distance = Math.Sqrt(tot);
                            b += distance;
                        }
                    }
                    b = b / cnt;
                    var sht = s.Where(x => x.dataPointNumber == ListPoints[k][i].Number).SingleOrDefault();
                    sht.b = b;
                    sht.s = (b - sht.a) / Math.Max(sht.b, sht.a);
                }

                int tmpK = (k + 1) - (k + 1 - nonEmptyClusters.Count);

                var yValue = s.Average(x => x.s);

                var oldPoint = chart1.Series["Silhouette"].Points.Where(x => x.XValue == tmpK).SingleOrDefault();

                if (oldPoint != null && oldPoint.YValues[0] < yValue)
                {
                    chart1.Series["Silhouette"].Points.Remove(oldPoint);
                    chart1.Series["Silhouette"].Points.AddXY(tmpK, yValue);
                }
                else if(oldPoint == null)
                {
                    chart1.Series["Silhouette"].Points.AddXY(tmpK, yValue);
                }

                if(value < yValue)
                {
                    value = yValue;
                    finalK = tmpK;
                }
            }

            textBox1.Text = finalK.ToString();
            numberOfCluster = finalK;
        }

    }

}
