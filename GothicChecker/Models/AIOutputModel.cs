using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicChecker.Models
{
    public class AIOutputModel
    {
        public string Instance { get; set; }
        public string Owner { get; set; }
        public string Text { get; set; }
        public string FileName { get; set; }

        public AIOutputModel(string instance, string owner, string text, string fileName)
        {
            Instance = instance;
            Owner = owner;
            Text = text;
            FileName = fileName;
        }

        internal static string MakeDiaString(string instance, string dialoge)
        {
            string whiteSpace = new String(' ', 75 - instance.Length);
            return (instance + whiteSpace + dialoge);
        }

        public override string ToString()
        {
            return MakeDiaString(Instance, Text);
        }
    }
}
