using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tambor : MonoBehaviour
{


    public GameObject text;
 
 

 public void displayText ()
 {
     

     StartCoroutine(waiter());

     

 }

 

IEnumerator waiter()
{
    text.SetActive(true);
    text.transform.parent.gameObject.SetActive(true);
     text.GetComponent<Text>().text = "This is one of the drums I used to defeat Apofis...";
    yield return new WaitForSeconds(5);
	text.SetActive(false);
	text.transform.parent.gameObject.SetActive(false);
     text.GetComponent<Text>().text = "";
}
}

