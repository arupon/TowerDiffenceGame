using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinionMove : MonoBehaviour
{

    [SerializeField]
    private Transform destination;

    // Start is called before the first frame update
    public void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = destination.position;
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
}
