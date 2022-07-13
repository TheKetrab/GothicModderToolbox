using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.Models
{
    public enum Importance
    {
        Normal,
        Warning,
        Error
    }

    public class ProgressModel
    {

        public string File { get; set; }
        public string Msg { get; set; }
        public Importance Importance { get; set; } = Importance.Normal;


        private int _percent;
        public int Percent { 
            get => _percent;
            set => _percent = Math.Max(0, Math.Min(100, value));
        }

        public ProgressModel()
        {

        }

        public ProgressModel(string msg, int percent)
        {
            Msg = msg;
            Percent = percent;
        }

    }
}
