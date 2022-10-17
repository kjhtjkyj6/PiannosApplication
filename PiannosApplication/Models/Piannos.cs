using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PiannosApplication.Models
{
    public class Piannos
    {
        public int Id { get; set; }
        public string Company { get; set; }// Company of piano

        public string Type { get; set; }// electrical or manual
        public string Color { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        public string WireType { get; set; }// Wiretype : Copper wire, Metal Wire 
        public int CustomerReview { get; set; }
    }
}
