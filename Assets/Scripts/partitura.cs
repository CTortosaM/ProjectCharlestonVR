using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class partitura: MonoBehaviour
{
    public GameObject text;
    public GameObject audioManager;
    private AudioSource music;
 
    private bool isPlaying=false;

void Start(){

    music=audioManager.GetComponents<AudioSource>()[0];

}

 public void play ()
 {
     
	
     if(isPlaying){
	music.Stop();
	}else{
	music.Play();
	StartCoroutine(waiter());
	}

     isPlaying=!isPlaying;

 }

 

IEnumerator waiter()
{
    text.SetActive(true);
     text.GetComponent<Text>().text = "This is some beautiful music, sounds like Chopin.";
    yield return new WaitForSeconds(5);
	text.SetActive(false);
     text.GetComponent<Text>().text = "";
}
}

