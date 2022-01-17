using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class ProvidedService
    {
        [Key]
        public int Id { get; set; }
        [Column("Patient")]
        public int PatientId { get; set; }
        [Column("Service")]
        public int ServiceId { get; set; }
        public DateTime ProvideDate { get; set; }
        public int Count { get; set; }

        public Patient Patient { get; set; }
        public Service Service { get; set; }
    }
}
