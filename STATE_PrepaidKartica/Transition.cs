using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    internal class Transition
    {
        public ProjectState ProjectState { get; set; }
        public ActivitationEvent ActivitationEvent { get; set; }

        public Transition(ProjectState projectState, ActivitationEvent activitationEvent)
        {
            ProjectState = projectState;
            ActivitationEvent = activitationEvent;
        }

        public override bool Equals(object obj)
        {
            return obj is Transition transition &&
                   ProjectState == transition.ProjectState &&
                   ActivitationEvent == transition.ActivitationEvent;
        }

        public override int GetHashCode()
        {
            int hashCode = -1003667411;
            hashCode = hashCode * -1521134295 + ProjectState.GetHashCode();
            hashCode = hashCode * -1521134295 + ActivitationEvent.GetHashCode();
            return hashCode;
        }
    }
}
