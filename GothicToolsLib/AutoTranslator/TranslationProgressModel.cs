using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.AutoTranslator
{
    public class TranslationProgressModel
    {
        public string Msg { get; set; }

        private int _percent;
        public int Percent
        {
            get => _percent;
            set => _percent = Math.Max(0, Math.Min(100, value));
        }
    }
}
