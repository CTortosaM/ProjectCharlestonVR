using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SillaPlegar : MonoBehaviour
{

	Animator m_Animator;
	public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
	m_Animator.speed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameObject.transform.position - player.transform.position).magnitude < 5.0f)
		m_Animator.Play("Take 001", 0, 1.0f);
    }

    /*void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {

		 

	}
    }*/

}
