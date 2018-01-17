using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Patrol")]
public class PatrolAction : Actions {

    public override void Act(StatesController controller)
    {

        Patrol(controller);
    }

    private void Patrol(StatesController controller)
    {
        controller.navMeshAgent.destination = GameObject.FindGameObjectWithTag("Player").transform.position;
        //controller.navMeshAgent.destination = controller.wayPointlist[controller.nextWaypoint].position;
        //controller.navMeshAgent.Resume();

        //if (controller.navMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance && !controller.navMeshAgent.pathPending)
        //{

        //    controller.nextWaypoint = (controller.nextWaypoint + 1) % controller.wayPointlist.Count;
        //}

    }
}
