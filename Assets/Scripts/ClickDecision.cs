using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/ClickDecision")]
public class ClickDecision : Decision
{


    public override bool Decide(StatesController controller)
    {
        bool cap_hp = Life(controller);
        //Debug.Log("Target visible: " + targetVisible);
        return cap_hp;
    }

    private bool Life(StatesController controller)
    {
        if (controller.enemyStats.HP < 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
