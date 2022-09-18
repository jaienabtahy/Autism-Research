using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCControl : MonoBehaviour
{

    public Transform transformToFollow;
    public NavMeshAgent agent;
    public Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        agent.destination = transformToFollow.position;
        if (agent.velocity.sqrMagnitude < 1f)
            animator.SetBool("move", false);
        else
            animator.SetBool("move", true);
     


    }

}

