using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Summon")]
public class SummonAction : Actions
{

    public override void Act(StatesController controller)
    {
        Summon(controller);
    }

    private void Summon(StatesController controller)
    {
        for (int i = 1; i < controller.enemyStats.SumNbr + 1; i++)
            Instantiate(controller.enemyStats.SummPrefab,controller.transform.position + new Vector3(2*i , 0, 0),controller.gameObject.transform.rotation);
    }

}
