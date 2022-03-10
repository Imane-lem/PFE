using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEDal.Modeles
{
    public class Article
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId{ get; set; }
        public string Designation { get; set; }
        public int Famille { get; set; }
        public int Prix { get; set; }
        public int QTE_Stock { get; set; }
        public int QET_Min { get; set; }

    }
}
