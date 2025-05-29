using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        public int RollNo { get; set; }
        public DateTime AdmissionDate { get; set; }

        public int SectionNo {  get; set; }
        public int BatchNo { get; set; }
        public string StudentPicture { get; set; }

      


    }
}
