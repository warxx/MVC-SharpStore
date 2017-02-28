using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.BindingModels;
using SharpStore.Data;
using SharpStore.Models;

namespace SharpStore.Services
{
    public class MessagesService : Service
    {
        public MessagesService(SharpStoreContext context) : base(context)
        {
        }

        public void AddMessageFromBind(MessageBinding msgBinding)
        {
            var message = new Message()
            {
                MessageText = msgBinding.Message,
                Sender = msgBinding.Sender,
                Subject = msgBinding.Subject
            };

            context.Messages.Add(message);
            context.SaveChanges();
        }
    }
}
