using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {

        public int ID { get; set; }
        [Required]
        public string EmployeeName {  get; set; }

        public int Age {  get; set; }   

        public GenderType Gender { get; set; }  

        public DateTime DOJ { get; set; }

        [Required]
        public DesignationType Designation {  get; set; }

        public int Salary {  get; set; }    
    }

    public enum GenderType
    {
        Male,
        Female,
    }

    public enum DesignationType
    {
        JEX,
        SAM,
        AM,
        DyM,
        AGM,
        DGM,
        GM
      
    }
}
