using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class SettingsWithCollection
    {
        public ICollection<string> props { get; set; } = new List<string>() { "default" };
    }
}
