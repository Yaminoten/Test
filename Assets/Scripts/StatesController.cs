using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class StatesController : MonoBehaviour {

    public State CurrentState;
    public EnemyStats enemyStats;
    public Transform eyes;
    public State remainState;
    public GameObject bullet;

    [HideInInspector] public NavMeshAgent navMeshAgent;
  //  [HideInInspector] public Complete.TankShooting tankShooting;
    //[HideInInspector]
    public List<Transform> wayPointlist;
    public int nextWaypoint;
    [HideInInspector] public Transform chaseTarget;
     public Transform AttackTarget;
    [HideInInspector] public Transform shell;
    [HideInInspector] public float stateTimeElapsed;
    [HideInInspector] public bool shelled ;
    [HideInInspector] public bool grounded = false;
    [HideInInspector] public bool fire = false;
    [HideInInspector] public float timer;
    public GameObject[] list;
    

    private bool aiActive = true;

    private void Awake()
    { 


 //       tankShooting = GetComponent<Complete.TankShooting>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        if (gameObject.tag == "Player")
        {
            shell = gameObject.transform.GetChild(2).GetChild(0);
            shell.GetComponent<NavMeshAgent>().enabled = false;
        }

    }

    public void SetupAI(bool aiActivationFromTankManager, List<Transform> wayPointsFromTankManager)
    {
        wayPointlist = wayPointsFromTankManager;
        aiActive = aiActivationFromTankManager;

        if (aiActive)
        {
            navMeshAgent.enabled = true;
        }
        else
        {
            navMeshAgent.enabled = false;
        }
    }

    public void Update()
    {
        if (!aiActive)
        {
            return;
        }

        if (grounded)
        {
            StartCoroutine(Switch());
        }

        CurrentState.UpdateState(this);

        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(1))
        {
            enemyStats.clicked = true;
        }
    }

    private void OnDrawGizmos()
    {
        if (CurrentState != null && eyes != null)
        {
            Gizmos.color = CurrentState.sceneColorGizmos;
            Gizmos.DrawWireSphere(eyes.position, enemyStats.lookSphereCastRadius);
        }
    }

    public void TransitionToState(State nextState)
    {
        if (nextState != remainState)
        {
            CurrentState = nextState;
            OnExitState();
        }
    }

    public bool CheckIfCountDownElapsed(float duration)
    {
        stateTimeElapsed += Time.deltaTime;
        return (stateTimeElapsed >= duration);
    }

    private void OnExitState()
    {
        stateTimeElapsed = 0;
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(3f);
        this.grounded = false;
        Debug.Log("Ungrounded");
    }

    public void List()
    {
        list = GameObject.FindGameObjectsWithTag("Player");

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].GetComponent<StatesController>().shelled == false)
            {
                AttackTarget = list[i].transform;
            }
        }
    }
}
