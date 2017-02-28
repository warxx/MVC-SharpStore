using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.Data;

namespace SharpStore.Services
{
    public abstract class Service
    {
        protected SharpStoreContext context;

        public Service(SharpStoreContext context)
        {
            this.context = context;
        }
    }
}
