using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Classes
{
    [Table ("Sala", Schema = "public")]
    public class Sala
    {
        [Key]
        public int id_sala { get; set; }

        [Display(Description="Nome")]
        public String nome { get; set; }

        public int status { get; set; }
    }
}
