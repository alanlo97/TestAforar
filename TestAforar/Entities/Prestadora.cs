using System;
using System.ComponentModel.DataAnnotations;

namespace TestAforar.Entities
{
    public class Prestadora
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Perdiodo { get; set; }
        [Required]
        public string dbs_cliente { get; set; }

    }
}
