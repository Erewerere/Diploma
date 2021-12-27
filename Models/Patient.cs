using System;
using Microsoft.EntityFrameworkCore;


namespace Diploma.Models
{
    class Patient
    {
        public int Id { get; set; }
        
        public string FIO { get; set; }
        public int Age { get; set; }
        public DateTime BirhDate { get; set; }
        public string Location { get; set; } = "";
        public enum Sex { Чоловіча, жіноча }
        
        public static implicit operator DbSet<object>(Patient v)
        {
            throw new NotImplementedException();
        }
    }
}
