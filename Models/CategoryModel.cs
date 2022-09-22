using System.ComponentModel.DataAnnotations;

namespace ContactCrate.Models;

public class CategoryModel
{
    public int Id { get; set; }

    [Required]
    public string? AppUserId { get; set; }

    [Required]
    [Display(Name = "Category Name")]
    public string? Name { get; set; }

    // Virtual properties
    public virtual AppUserModel? AppUser { get; set; }
    public virtual ICollection<ContactModel> Contacts { get; set; } = new HashSet<ContactModel>();
}
