using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPgame
{
    public class SpecialAction: Action
    {
        public override void execute()
        {
            chooseTarget();
            Primary.useSpecial(Target);
        }
    }
}
