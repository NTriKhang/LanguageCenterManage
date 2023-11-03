using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Services.Kmean.Silhouette
{
    public class Silhouette
    {
        public int dataPointNumber { get; set; }
        public double a {  get; set; }
        public double b { get; set; }
        public double s { get; set; }
    }
}
