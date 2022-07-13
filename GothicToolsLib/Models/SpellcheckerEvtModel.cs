using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.Models
{
    public enum SpellcheckerEvtReason
    {
        Message,
        Typo,
        EndsWithoutDot,
        StartsWithLowerCase
    }

    public class SpellcheckerEvtModel
    {

        public SpellcheckerEvtModel(SpellcheckerEvtReason r, params string[] args)
        {
            Reason = r;
            Args = args;
        }

        public SpellcheckerEvtReason Reason { get; set; }
        public string[] Args { get; set; }

    }
}
