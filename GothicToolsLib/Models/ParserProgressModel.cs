using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.Models
{
    public class ParserProgressModel
    {
        public string File { get; set; }
        public string Msg { get; set; }

        private int _percent;
        public int Percent { 
            get => _percent;
            set => _percent = Math.Max(0, Math.Min(100, value));
        }

        public ParserProgressModel()
        {

        }

        public ParserProgressModel(string msg, int percent)
        {
            Msg = msg;
            Percent = percent;
        }

    }
}
