using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIAttacks : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    private bool isAttacking;
    public float attackDistance;

    void Awake ()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= attackDistance)
            if (!isAttacking)
            {
                StartCoroutine("Attack", 1.5f);
            }
    }

    IEnumerator Attack(float WaitTime)
    {
        isAttacking = true;
        animator.SetTrigger("Attack");
        yield return new WaitForSeconds(WaitTime);
        isAttacking = false;
    }
}
