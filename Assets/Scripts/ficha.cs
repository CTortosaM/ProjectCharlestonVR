using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ficha: MonoBehaviour
{
    public GameObject text;
    public GameObject audioManager;
    private AudioSource music;
    public GameObject apofis;
 
    

void Start(){

    music=audioManager.GetComponents<AudioSource>()[1];

}

 public void play ()
 {
     
	
     
	
	StartCoroutine(waiter());
	

 }

 

IEnumerator waiter()
{
    apofis.SetActive(false);
    music.Play();
    yield return new WaitForSeconds(3);
    
    text.SetActive(true);
     text.GetComponent<Text>().text = "To be continued...";
    yield return new WaitForSeconds(5);
	text.SetActive(false);
     text.GetComponent<Text>().text = "";
	SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
}
}

