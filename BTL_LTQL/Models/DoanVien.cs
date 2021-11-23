using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("DoanVien")]
    public class DoanVien
    {
        [Key]

        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }
        public string NgayvaoDoan { get; set; }
        public string IDChiDoan { get; set; }
    }
}