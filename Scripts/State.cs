using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/State")]
public class State : ScriptableObject
{
    public Actions[] actions;
    public Transition[] transition;
    public Color sceneColorGizmos = Color.grey;

    public void UpdateState(StatesController controller)
    {
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(StatesController controller)
    {
        for (int i=0; i < actions.Length; i++)
        {
            actions[i].Act(controller);
        }
    }

    private void CheckTransitions(StatesController controller)
    {
        for (int i = 0; i < transition.Length; i++)
        {
            bool decisionSucceeded = transition[i].decision.Decide(controller);

            if (decisionSucceeded)
            {
                controller.TransitionToState(transition[i].trueState);
            }
            else
            {
                controller.TransitionToState(transition[i].falseState);
            }
        }
    }

}
