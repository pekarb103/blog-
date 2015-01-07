using System.ComponentModel.DataAnnotations;
namespace MvcApplication1.Models
{
    public class UserModel
    {
        [Range(4, 100)]
        public int? Age { get; set; }
        public string Username { get; set; }
    }
}
