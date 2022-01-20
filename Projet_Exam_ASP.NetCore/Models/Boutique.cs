using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Exam_ASP.NetCore.Models
{
    public class Boutique 
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String Nom { get; set; }
        public String Description { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String Telephone { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String Ville { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String site { get; set; }
        public String Adresse { get; set; }
        public int ImageId { get; set; }
        [ForeignKey("ImageId")]
        public Image Image { get; set; }
    }
}
