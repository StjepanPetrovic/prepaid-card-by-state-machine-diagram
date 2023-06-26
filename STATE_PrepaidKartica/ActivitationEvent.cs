using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    public enum ActivitationEvent
    {
        Activation,
        Payment,
        WithdrawMoney,
        NotEnoughMoney,
        EnoughMoney,
    }
}
