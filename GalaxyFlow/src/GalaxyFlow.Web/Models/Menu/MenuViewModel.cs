using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyFlow.Web.Models.Menu
{
    public class MenuViewModel
    {
        public string Id { get; set; }

        public string ParentId { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }

        public string Url { get; set; }
    }
}
