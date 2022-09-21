using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactCrate.Models;

public class ContactModel
{
    public int Id { get; set; }
    public int AppUserId { get; set; } // FK

    //Properties
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

    [Display(Name = "Birthday")]
    [DataType(DataType.Date)]
    public DateTime? BirthDate { get; set; }

    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }





    [EmailAddress]
    public string? Email { get; set; }

    [Phone]
    public string LandlineNumber { get; set; }


    // Virtual Properties


}
