using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStore.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Sender { get; set; }

        public string Subject { get; set; }

        public string MessageText { get; set; }
    }
}
