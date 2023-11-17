using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Models
{
    public class Band
    {
        [Key]
        public string Id { get; set; }
        public decimal BandNumber { get; set; }
        public string CourseTypeId { get; set; }
        [ForeignKey(nameof(CourseTypeId))]
        public CourseType CourseType { get; set; }
    }
}
