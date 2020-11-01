using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTraker_HW5.Models
{
    public class ClsAssignment 
    {
        [Key]
        public int AssignmentId { get; set; }
        [Required(ErrorMessage = "You need to set a priority")]
        public int Priority { get; set; }
        [Required]
        [Display(Name = "When is it due?")]
        public DateTime DueDate { get; set; }
        [Required]
        [Display(Name = "What course?")]
        public string CourseName { get; set; }
        [Required]
        [Display(Name = "Give the assignment a title:")]
        public string AssignmentTitle { get; set; }
        [Display(Name = "Add some notes about what you need to do to complete it:")]
        public string Notes { get; set; }

        /*public int CompareTo(object obj)
        {
            return Priority.CompareTo(obj);
        }*/

        /*public int CompareTo(object obj)
        {
            //return Due.CompareTo(obj);
            return DueDate.CompareTo(obj);
        }*/
    }

   
}
