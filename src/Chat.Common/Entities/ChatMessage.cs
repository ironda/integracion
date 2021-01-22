using System;
using System.ComponentModel.DataAnnotations;

namespace Chat.Common.Entities
{
    public class ChatMessage
    {
        [Key]
        public int IdChatMessage { get; set; }

        [StringLength(15)]
        public string Author { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}
