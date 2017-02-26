using System.ComponentModel.DataAnnotations.Schema;
using CrudAPI.DataLayer.Interfaces;

namespace CrudAPI.DataLayer.Models
{
    [Table("User")]
    public partial class User : IEntity
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