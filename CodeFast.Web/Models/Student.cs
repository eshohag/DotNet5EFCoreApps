using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFast.Web.Models
{
    [Table("Students")]
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
