using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeMVP.Models
{
    public class EmployeeModel
    {
        private int id;
        private string name;
        private string gender;
        private string department;
        private string post;

        public int Id { get => id; set => id = value; }
        
        [DisplayName("Employee Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Employee Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get => gender; set => gender = value; }

        [DisplayName("Employee Department")]
        [Required(ErrorMessage = "Department is required")]
        public string Department { get => department; set => department = value; }

        [DisplayName("Employee Post")]
        [Required(ErrorMessage = "Post is required")]
        public string Post { get => post; set => post = value; }
    }
}
