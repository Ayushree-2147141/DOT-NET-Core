using System.ComponentModel.DataAnnotations;
namespace WebApp.ViewModel
{
    public class SampleRequest
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(length:10)]
        public string Name { get; set; }
    }
}
