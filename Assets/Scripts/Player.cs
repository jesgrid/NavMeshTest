using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public Transform Target;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Target.position;
    }
}
