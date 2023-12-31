﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Services.ExcelService;
using LanguageCenterManage.Services.Kmean.Elbow;
using LanguageCenterManage.Services.Kmean.Entities;
using LanguageCenterManage.Services.Kmean.Silhouette;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LanguageCenterManage.Services.Kmean
{

    public partial class KmeanForm : Form
    {
        private AppDbContext _db;

        private bool isFinished;
        private int iterationNumber;
        private List<DataPoint> listDataPoint;


        private List<Cluster> listCluster;

        //private List<DPLimit> listDPLimit;


        private List<Color> listColor;


        private long numberOfDataPoints;

        private long numberOfClusters;
        private int year;

        //private int randType;
        //private enum RANDOMTYPE_DP
        //{
        //    Random = 1,
        //    GoodRandom = 2
        //}
        public KmeanForm()
        {
            _db = new AppDbContext();
            InitializeComponent();

            InitializeVariables();
        }

        #region Functional Methods

        private void InitializeVariables()
        {
            //numberOfDataPoints = 1000;

            //numberOfClusters = 4;

            //randType = (int)RANDOMTYPE_DP.Random;

            // Create lists
            listCluster = new List<Cluster>();
            listDataPoint = new List<DataPoint>();
            //listDPLimit = new List<DPLimit>();

            listColor = new List<Color>();
            listColor.Add(System.Drawing.Color.Yellow);
            listColor.Add(System.Drawing.Color.Red);
            listColor.Add(System.Drawing.Color.Black);
            listColor.Add(System.Drawing.Color.Blue);
            listColor.Add(System.Drawing.Color.Gray);
            listColor.Add(System.Drawing.Color.Orange);
            listColor.Add(System.Drawing.Color.Navy);
            listColor.Add(System.Drawing.Color.Pink);
            listColor.Add(System.Drawing.Color.Azure);
            listColor.Add(System.Drawing.Color.Chocolate);
            listColor.Add(System.Drawing.Color.SteelBlue);

            // Create DataPoints
            //CreateDataPoints();
        }

        private void CreateDataPoints()
        {
            // Recreate lists for reset
            listDataPoint = new List<DataPoint>();
            listCluster = new List<Cluster>();
            //listDPLimit = new List<DPLimit>();

            //Change this
            var listAgeAndBand = (from student in _db.Students
                                  from joins in _db.Joins
                                  from classes in _db.Classes
                                  from courses in _db.Courses
                                  where student.Id == joins.StudentId
                                  && joins.ClassId == classes.Id
                                  && classes.CourseId == courses.Id
                                  && courses.DateStart.Year == year
                                  select new AgeAndBand
                                  {
                                      studentId = student.Id,
                                      Age = DateTime.Now.Year - student.Birth.Year,
                                      Band = courses.Band
                                  }).GroupBy(x => x.studentId)
                                    .ToList(); ;

            List<AgeAndBand> listAgeAndBandDistinct = new List<AgeAndBand>();
            foreach(var ageAndBand in listAgeAndBand)
            {
                AgeAndBand a = new AgeAndBand()
                {
                    Age = 0,
                    studentId = "",
                    Band = -1,
                };
                foreach(var student in ageAndBand)
                {
                    if(student.Band > a.Band)
                    {
                        a = student;
                    }
                }
                listAgeAndBandDistinct.Add(a);
            }
            int largestAge = listAgeAndBandDistinct.Max(x => x.Age);
            double largestBand = listAgeAndBandDistinct.Max(x => x.Band);
            //panel1.Padding = new Padding(50);
            // Create datapoints and add to list
            int panelWidth = panel1.Size.Width - 100;
            int panelHeight = panel1.Size.Height - 100;

            for (int i = 0; i < listAgeAndBandDistinct.Count; i++)
            {
                int xPoint = (listAgeAndBandDistinct[i].Age * panelWidth / largestAge) + 50;
                int yPoint = (Convert.ToInt32(listAgeAndBandDistinct[i].Band * panelHeight / largestBand)) + 50;

                DataPoint dataPoint = new DataPoint(i + 1, xPoint, yPoint, null);
                dataPoint.UserId = listAgeAndBandDistinct[i].studentId;
                dataPoint.Band = listAgeAndBandDistinct[i].Band;
                listDataPoint.Add(dataPoint);
            }

        }

        private void CreateClusters()
        {
            listCluster = new List<Cluster>();
            Random rand = new Random();

            for (int i = 0; i < numberOfClusters; i++)
            {
                int xPoint = rand.Next(panel1.Size.Width);
                int yPoint = rand.Next(panel1.Size.Height);

                Cluster cluster = new Cluster(i + 1, xPoint, yPoint, listColor[i]);
                listCluster.Add(cluster);
            }
        }

        private void PaintInPanel()
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = panel1.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Red, 5);

            // Draw datapoints
            foreach (DataPoint dataPoint in listDataPoint)
            {
                if (dataPoint.Cluster != null)
                {
                    myPen.Color = dataPoint.Cluster.ColorOfPoint;
                }

                Rectangle rect = new Rectangle(dataPoint.XPoint, dataPoint.YPoint, 1, 1);
                graphicsObj.DrawEllipse(myPen, rect);
            }

            // Draw clusters
            foreach (Cluster cluster in listCluster)
            {
                Rectangle rect = new Rectangle(cluster.XPoint, cluster.YPoint, 10, 10);
                myPen.Color = cluster.ColorOfPoint;
                graphicsObj.DrawRectangle(myPen, rect);
            }
        }
        private void Reset()
        {
            year = Convert.ToInt32(YearCb.Text);
            //numberOfDataPoints = Convert.ToInt64(YearCb.Text);
            //Create limits of coordinates of datapoints

            CreateDataPoints();

            panel1.Invalidate();
        }

        private void InitializeCluster()
        {
            int kLimit = 7;
            iterationNumber = 0;
            if (elbowRadio.Checked)
            {
                List<List<DataPoint>> res = new List<List<DataPoint>>();
                for (int i = 1; i <= kLimit; i++)
                {
                    numberOfClusters = i;
                    CreateClusters();
                    FindtheResult();
                    var tmpPoints = newDatapoints();
                    res.Add(tmpPoints);
                }
                ElbowForm elbowForm = new ElbowForm(res);
                elbowForm.ShowDialog();
                if (elbowForm.numberOfCluster != 0)
                {
                    tfNumberOfCluster.Text = elbowForm.numberOfCluster.ToString();
                }
            }
            else if (SihoutteRadio.Checked)
            {
                List<List<DataPoint>> res = new List<List<DataPoint>>();
                for (int i = 1; i <= kLimit; i++)
                {
                    numberOfClusters = i;
                    CreateClusters();
                    FindtheResult();
                    var tmpPoints = newDatapoints();
                    res.Add(tmpPoints);
                }
                SilhouetteForm silhouette = new SilhouetteForm(res);
                silhouette.ShowDialog();
                if (silhouette.numberOfCluster != 0)
                {
                    tfNumberOfCluster.Text = silhouette.numberOfCluster.ToString();
                }
            }

            numberOfClusters = Convert.ToInt64(tfNumberOfCluster.Text);
            // Create clusters
            CreateClusters();

            panel1.Invalidate();
        }
        private List<DataPoint> newDatapoints()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (DataPoint point in listDataPoint)
            {
                dataPoints.Add(new DataPoint(point.Number, point.XPoint, point.YPoint, null)
                {
                    Distance = point.Distance,
                    Cluster = new Cluster(point.Cluster.Number, point.Cluster.XPoint, point.Cluster.YPoint, point.Cluster.ColorOfPoint)
                });
            }
            return dataPoints;
        }
        private void AssignDataPointsToCloserCluster()
        {
            iterationNumber++;
            foreach (DataPoint dataPoint in listDataPoint)
            {
                Cluster nearestCluster = null;
                double distance = 999999999999;
                foreach (Cluster cluster in listCluster)
                {
                    double tempDistance = GetDistance(dataPoint, cluster);
                    if (tempDistance < distance)
                    {
                        nearestCluster = cluster;
                        distance = tempDistance;
                    }
                }
                dataPoint.Cluster = nearestCluster;
                dataPoint.Distance = distance;
            }


            // redraw
            panel1.Invalidate();
        }

        private void CalculateCenterOfEachCluster()
        {
            foreach (DataPoint dataPoint in listDataPoint)
            {
                dataPoint.Cluster.XTotal += dataPoint.XPoint;
                dataPoint.Cluster.YTotal += dataPoint.YPoint;

                dataPoint.Cluster.TotalDataPoints++;
            }

            bool isSame = true;
            foreach (Cluster cluster in listCluster)
            {
                if (cluster.TotalDataPoints > 0)
                {
                    cluster.setXPoint(Convert.ToInt16(cluster.XTotal / cluster.TotalDataPoints));
                    cluster.setYPoint(Convert.ToInt16(cluster.YTotal / cluster.TotalDataPoints));

                    if (!(cluster.XPoint == cluster.OldXPoint &&
                        cluster.YPoint == cluster.OldYPoint &&
                        cluster.OldTotalDataPoints == cluster.OldTotalDataPoints))
                    {
                        isSame = false;
                    }

                    cluster.SetToDefaultTotal();
                }
            }

            if (isSame)
            {
                isFinished = true;
                if(!elbowCheck && !sihouetteCheck)
                {
                    string msg = "Finished" + Environment.NewLine;

                    foreach (Cluster cluster in listCluster)
                    {
                        msg += "Cluster " + cluster.Number + "(" + cluster.ColorOfPoint.ToString() + ")" +
                            " = " + cluster.OldTotalDataPoints.ToString() + "datapoints" + Environment.NewLine;
                    }

                    msg += "Iteration Number : " + iterationNumber.ToString();
                    MessageBox.Show(msg);
                }
            }


            // redraw
            panel1.Invalidate();
        }

        private double GetDistance(DataPoint dataPoint, Cluster cluster)
        {
            int xdis = (dataPoint.XPoint - cluster.XPoint);
            int ydis = (dataPoint.YPoint - cluster.YPoint);
            int tot = (xdis * xdis + ydis * ydis);
            double distance = Math.Sqrt(tot);


            return distance;
        }

        private void FindtheResult()
        {
            isFinished = false;
            while (!isFinished)
            {
                AssignDataPointsToCloserCluster();
                CalculateCenterOfEachCluster();
            }
        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaintInPanel();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnInitializeCluster_Click(object sender, EventArgs e)
        {
            // Initilialize clusters
            InitializeCluster();
        }

        private void btnIterate_Click(object sender, EventArgs e)
        {
            AssignDataPointsToCloserCluster();
        }


        private void btnCalculateCenterOfEachCluster_Click(object sender, EventArgs e)
        {
            CalculateCenterOfEachCluster();
        }

        private void btnFindTheResult_Click(object sender, EventArgs e)
        {
            FindtheResult();
        }

        private void KmeanForm_Load(object sender, EventArgs e)
        {

        }

        private void YearCb_DropDown(object sender, EventArgs e)
        {

            StudentEachYear studentEachYear = new StudentEachYear();
            studentEachYear.ShowDialog();
            YearCb.Text = studentEachYear.Year.ToString();
            numberOfDataPoints = studentEachYear.Quantity;
            YearCb.DroppedDown = false;

            Reset();

            //YearCb.DropDown += YearCb_DropDown;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            List<List<UserDTO>> listUserDtos = new List<List<UserDTO>>(); 
            for (int i = 0; i < numberOfClusters; i++)
            {
                List<UserDTO> users = new List<UserDTO>();
                foreach (var point in listDataPoint)
                {
                    if (point.Cluster.Number == i + 1)
                    {
                        var user = _db.Students.Where(x => x.Id == point.UserId)
                                            .Select(x => new UserDTO
                                            {
                                                Id = x.Id,
                                                FirstName = x.FirstName,
                                                LastName = x.LastName,
                                                Email = x.Email,
                                                Phone = x.Phone,
                                                Birth = x.Birth,
                                                Band = point.Band
                                            })
                                            .SingleOrDefault();
                        users.Add(user);
                    }
                }
                UserByGroupForm userByGroupForm = new UserByGroupForm(users);
                userByGroupForm.ShowDialog();
                listUserDtos.Add(users);
            }
            if(MessageBox.Show("Do you want to save this", "Notify", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExcelService.ExcelService excelService = new ExcelService.ExcelService();
                bool response = excelService.ExportUserDto(listUserDtos);
                if(response == true)
                {
                    MessageBox.Show("Save successfully","200", MessageBoxButtons.OK);
                }
            }
        }
        bool elbowCheck = false;
        bool sihouetteCheck = false;
        private void elbowRadio_Click(object sender, EventArgs e)
        {
            if (elbowCheck)
            {
                elbowCheck = false;
                elbowRadio.Checked = false;
            }
            else
            {
                elbowCheck = true;
                elbowRadio.Checked = true;  
            }
        }

        private void SihoutteRadio_Click(object sender, EventArgs e)
        {
            if (sihouetteCheck)
            {
                SihoutteRadio.Checked = false;
                sihouetteCheck = false;
            }
            else
            {
                SihoutteRadio.Checked = true;
                sihouetteCheck = true;
            }
        }

        private void SihoutteRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void elbowRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    public class AgeAndBand
    {
        public string studentId { set; get; }
        public int Age { set; get; }
        public double Band { set; get; }

    }
}
