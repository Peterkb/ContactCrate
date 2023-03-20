using ContactCrate.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactCrate.Models;

public class Contact
{
    public int Id { get; set; }
    public int AppUserID { get; set; }

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
    public States? State { get; set; }
    public string? Country { get; set; }

    [Required]
    [Display(Name = "Zip Code")]
    [DataType(DataType.PostalCode)]
    public int ZipCode { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Phone]
    [Display(Name = "Landline Number")]
    public string? LandlineNumber { get; set; }

    [Phone]
    [Display(Name = "Cellphone Number")]
    public string? CellNumber { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateCreated { get; set; }

    // Avatar
    public byte[]? ImageData { get; set; }
    public string? ImageType { get; set; }
    [NotMapped]
    public IFormFile? IamgeFile { get; set; }

    // Virtual Properties
    public virtual AppUser? AppUser { get; set; }
    public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();

}
