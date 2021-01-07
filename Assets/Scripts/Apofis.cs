using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apofis : MonoBehaviour
{


    public GameObject text;
 
 

 public void displayText ()
 {
     

     StartCoroutine(waiter());

     

 }

 

IEnumerator waiter()
{
    text.SetActive(true);
     text.GetComponent<Text>().text = "I don't like this thing, it reminds me of Apofis...";
    yield return new WaitForSeconds(5);
	text.SetActive(false);
     text.GetComponent<Text>().text = "";
}
}
