using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStore.Models
{
    public class Login
    {
        public int Id { get; set; }

        public string SessionId { get; set; }

        public virtual User User { get; set; }

        public bool IsActive { get; set; }
    }
}
