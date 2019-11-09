using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Document { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public string FullName => $"{FirstName}{LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
