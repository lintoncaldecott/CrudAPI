using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAPI.DataLayer.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public bool Status { get; set; }
    }
}