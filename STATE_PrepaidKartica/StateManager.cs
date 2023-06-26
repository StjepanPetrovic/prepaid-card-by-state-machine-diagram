using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    internal class StateManager
    {
        public ProjectState CurrentState { get; set; }
        private Dictionary<Transition, ProjectState> AllowedTransition { get; set; }

        public StateManager()
        {
            CurrentState = ProjectState.NotActive;
            SpecifyAllowedTransitions();
        }

        private void SpecifyAllowedTransitions()
        {
            AllowedTransition = new Dictionary<Transition, ProjectState>();

            AllowedTransition.Add(new Transition(ProjectState.NotActive, ActivitationEvent.Activation), ProjectState.Active);
            AllowedTransition.Add(new Transition(ProjectState.Active, ActivitationEvent.Payment), ProjectState.Active);
            AllowedTransition.Add(new Transition(ProjectState.Active, ActivitationEvent.EnoughMoney), ProjectState.Active);
            AllowedTransition.Add(new Transition(ProjectState.Active, ActivitationEvent.NotEnoughMoney), ProjectState.NotEnoughMoney);
            AllowedTransition.Add(new Transition(ProjectState.NotEnoughMoney, ActivitationEvent.Payment), ProjectState.Active);
        }

        public void MakeTransition(ActivitationEvent activitationEvent)
        {
            Transition transition = new Transition(CurrentState, activitationEvent);
            ProjectState resultingState;

            if (AllowedTransition.TryGetValue(transition, out resultingState) == false)
            {
                throw new ApplicationException($"Transition {CurrentState} -> {activitationEvent} is not possible!");
            }

            CurrentState = resultingState;
        }

        public override string ToString()
        {
            return CurrentState.ToString();
        }
    }
}
