using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Shield")]
public class ShieldAction : Actions {

    public override void Act(StatesController controller)
    {
        Shield(controller);
    }

    private void Shield(StatesController controller)
    {
        controller.gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }

}
