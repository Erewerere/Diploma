using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using Diploma.EF;
using Microsoft.EntityFrameworkCore;



namespace Diploma.Models
{
   public class Patient
    {
        [Key]
        public int Id { get; set; }
        public DisabilityGroup DisabilityGroup { get; set; }
        [Column("DisabilityGroup")]
        public int DisabilityGroupId { get; set; }
        public string Name{ get; set; }
        public string Surname { get; set; }
        public string Middlename{ get; set; }
        public string FIO => Surname + " " + Name + " " + Middlename;
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; } = "";      
        [Column("Sex")]
        public Sex Sex { get ; set ; }
        public SocialIntegration Integration { get; set; }
        [Column("Integration")]
        public int IntegrationId { get; set; }        
        public Decease Decease { get; set; }
        [Column("Decease")]
        public int DeceaseId { get; set; }

        
        public static implicit operator DbSet<object>(Patient v)
        {
            throw new NotImplementedException();
        }
    }
    public enum Sex { Чоловіча =1 , Жіноча =0 }
}
