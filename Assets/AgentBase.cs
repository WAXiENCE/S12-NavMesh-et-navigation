using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentBase : MonoBehaviour
{


    UnityEngine.AI.NavMeshAgent _agent;

    [SerializeField] GameObject _joueur;

    void Start()
    {
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
       
    }


    void Update()
    {
         _agent.SetDestination(_joueur.transform.position);
    }
}
