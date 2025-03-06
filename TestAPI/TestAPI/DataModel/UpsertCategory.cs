using System.ComponentModel.DataAnnotations;

namespace TestAPI.DataModel
{
    public class UpsertCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }

        public int? ParentCategoryId { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
