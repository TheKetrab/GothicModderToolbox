using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.Models
{
    public class NpcModel
    {
        public int Id { get; }
        public string Name { get; }
        public int DialogsDone => Dialogs.Count - Missing.Count;

        public double Percent => DialogsDone * 100.0 / Dialogs.Count;

        public List<AIOutputModel> Missing = new();
        public List<AIOutputModel> Dialogs = new();

        public NpcModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string BuildNpcInfo()
        {
            string space1 = new string(' ', 15 - Name.Length);
            string state = $"{Dialogs.Count - Missing.Count}/{Dialogs.Count}";
            string space2 = new string(' ',10-state.Length);
            return $"{Name}{space1}{state}{space2}LEFT: {Missing.Count}";
        }

    }
}
