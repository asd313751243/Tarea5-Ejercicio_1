using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    public class Valores
    {
        [Required]
        public double valor { get; set; }
    }
}
