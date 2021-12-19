using System.ComponentModel.DataAnnotations;

namespace AR.Presentetion.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
