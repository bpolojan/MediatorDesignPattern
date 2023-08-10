using System.ComponentModel.DataAnnotations;

namespace MediatR.Demo.Data
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(4000)]
        public string LastName { get; set; }

        [StringLength(1000)]
        public virtual string WebSite { get; set; }     
    }
}