using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.Patterns
{
    public class CustomPattern
    {
        public string Id { get; set; }
        public string Section { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Group { get; set; }

        public CustomPattern()
        {

        }

        public CustomPattern(string id, int group = 0)
        {
            Id = id;

            int a = id.IndexOf('_');
            int b = id.LastIndexOf('_');

            Section = id.Substring(a + 1, b - a - 1);
            Name = id.Substring(b + 1);

            Group = group;
        }
    }
}
