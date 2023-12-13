using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    /// <summary>
    /// Represents a photo entity. Contains properties for the photo ID, URL, 
    /// public ID, owning user, and whether it is the main photo for the user.
    /// The [Table] attribute specifies the database table name.
    /// <summary>
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int MyProperty { get; set; }
        public string PublicId { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public bool IsMain { get; set; }
    }
}