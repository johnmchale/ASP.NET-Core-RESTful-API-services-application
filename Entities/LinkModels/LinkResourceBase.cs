using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.LinkModels
{
    public class LinkResourceBase
    {
        public LinkResourceBase()
        { }

        public List<Link> Links { get; set; } = new List<Link>();
    }

}
