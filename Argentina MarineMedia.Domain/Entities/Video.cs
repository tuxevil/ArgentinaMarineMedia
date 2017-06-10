using System;
using System.Collections.Generic;
using System.Text;

namespace Argentina_MarineMedia.Domain
{
    public class Video: Identifier 
    {
        private string name;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
