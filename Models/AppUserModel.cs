using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ContactCrate.Models;

public class AppUserModel : IdentityUser
{
    [Required]
    [Display(Name = "First Name")]
    [StringLength(50, ErrorMessage = "{0} needs to be at least {2} and a max of {1} characters.", MinimumLength = 2)]
    public string? FirstName { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "{0} needs to be at least {2} and a max of {1} characters.", MinimumLength = 2)]
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }

    [NotMapped]
    public string? FullName { get { return $"{FirstName} {LastName}"; } }
}
