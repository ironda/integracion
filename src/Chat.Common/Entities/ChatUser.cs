using System.ComponentModel.DataAnnotations;

namespace Chat.Common.Entities
{
    public class ChatUser
    {
        [Key]
        public int IdUser { get; set; }

        [StringLength(15)]
        public string Name { get; set; }

        public string Password { get; set; }
    }
}
