using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoBrutalCompany.Events
{
    public class NoneEvent : BrutalEvent
    {
        public override string GetEventName()
        {
            return "We are all dead";
        }

        public override void OnLoadNewLevel(ref SelectableLevel newLevel, ConfigSettings config)
        {
        }
    }
}
