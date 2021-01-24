using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SillaPlegar : MonoBehaviour
{

	Animator m_Animator;
	private bool estaCerrada=false;
	

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
	
    }

    // Update is called once per frame
    void Update()
    {
        
		
    }

private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.tag == "Mano"){

	if(estaCerrada){

		m_Animator.Play("Take 001 0");
	}else{
		m_Animator.Play("Take 001");
	}

		estaCerrada= !estaCerrada;
	
	 
	};
    }

}
