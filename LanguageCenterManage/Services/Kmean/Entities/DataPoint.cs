using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageCenterManage.Services.Kmean.Entities
{
    public class DataPoint
    {
        public string UserId { get; set; }
        public double Band { get; set; }
        public int Number { get; set; }
        public int XPoint { get; set; }
        public int YPoint { get; set; }

        public Cluster Cluster { get; set; }
        public Cluster NearestNeighborCluster { set; get; } 

        public double Distance { get; set; }

        public DataPoint(int number, int xPoint, int yPoint, Cluster cluster)
        {
            Number = number;
            XPoint = xPoint;
            YPoint = yPoint;
            Cluster = cluster;
        }
    }

}
