using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterMessage
    {
        [Key]
        public int Id { get; set; }
        public string Sender { get; set; } //göndericinin mail adresi
        public string Receiver { get; set; } //alıcı
        public string ReceiverName { get; set; } 
        public string SenderName { get; set; } 
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
    }
}
