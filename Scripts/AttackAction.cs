using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Attack")]
public class AttackAction : Actions {

    public override void Act(StatesController controller)
    {
        Attack(controller);
    }

    private void Attack(StatesController controller)
    {
        controller.List();
        if (controller.AttackTarget!= null) //controller.fire)
        {
            //controller.fire = false;
            Debug.Log("Attack");
            Destroy(controller.AttackTarget.gameObject);
        }
    }

}
