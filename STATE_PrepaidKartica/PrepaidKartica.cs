using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    public class PrepaidKartica
    {
        public StateManager StateManager { get; set; }
        public string SerijskiBroj { get; set; }
        public double Iznos { get; set; }

        public PrepaidKartica(string serijskiBroj)
        {
            SerijskiBroj = serijskiBroj;
            StateManager = new StateManager();
        }

        public void Aktiviraj()
        {
            StateManager.MakeTransition(ActivitationEvent.Activation);
            Iznos = 100;
        }

        public void Uplati(double iznosUplate)
        {
            StateManager.MakeTransition(ActivitationEvent.Payment);
            Iznos += iznosUplate;
        }

        internal void Isplati(double iznosIsplate)
        {
            if (Iznos - iznosIsplate >= 0)
            {
                StateManager.MakeTransition(ActivitationEvent.EnoughMoney);
            Iznos -= iznosIsplate;
        }
            else
            {
                StateManager.MakeTransition(ActivitationEvent.NotEnoughMoney);
            }
        }

        public double getCardMoney()
        {
            return Iznos;
        }

        public ProjectState getState()
        {
            return StateManager.CurrentState;
        }
    }
}
