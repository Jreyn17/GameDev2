using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent navAgent;

    void Start()
    {
        //Get components
        navAgent = GetComponent<NavMeshAgent>();

        //Set the destination for the agent.
        navAgent.SetDestination(target.transform.position);
    }
}
