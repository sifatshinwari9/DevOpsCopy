using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public partial class CovidData
    {
        public int Id { get; set; }
        public string? patientId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Sex { get; set; }
        public int Age { get => DateTime.Now.Year - this.DateOfBirth.Year; }
        public string? Location { get; set; }
        public DateTime CovidDateTested { get; set; }        
        public string? CovidResult { get; set; }
    }
}
