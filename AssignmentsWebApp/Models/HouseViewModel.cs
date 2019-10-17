using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AssignmentsWebApp.Models
{
    public class HouseViewModel
    {
        public int Bedrooms { get; set; }

        public int SquareFeet { get; set; }

        public string DateBuilt { get; set; }
        
        public string Flooring { get; set; }
    }
}
