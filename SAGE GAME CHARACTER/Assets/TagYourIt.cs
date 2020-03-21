using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class TagYourIt : MonoBehaviour {

    public GameObject Player;
    private Animator anim;
    private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        anim = Player.GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollsionEnter(Collision collision)
    {
        if(collision.gameObject == Player){
            anim.speed = 0;
            agent.speed = 0;
            Invoke("ResetSpeed", 2.0f);
        }
    }

    void ResetSpeed()
    {
        anim.speed = 1;
        agent.speed = 0.5f ;
    }
}
