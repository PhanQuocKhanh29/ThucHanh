using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("ChiDoan")]
    public class ChiDoan
    {
        [Key]
        public string IDChiDoan { get; set; }
        public string TenChiDoan { get; set; }
    }
}