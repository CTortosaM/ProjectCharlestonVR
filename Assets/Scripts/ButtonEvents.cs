using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent myEvent;  //para definir en el Editor las funciiones a ejecutar en los botones

    public void m_enter()
    {
        //this.GetComponent<Animator>().SetTrigger("Highlighted");
    }
    public void m_exit()
    {
        //this.GetComponent<Animator>().SetTrigger("Normal");
    }

    public void m_click()
    {
        //this.GetComponent<Animator>().SetTrigger("Pressed");
        myEvent.Invoke();
    }

    /// <summary>
    /// Funciones de cada botón
    /// </summary>
    public void ButtonClickPlay()
    {
        //Codigo que cambia de escena
        //SceneManager.LoadScene("Nombre", LoadSceneMode.Single);
        Debug.Log("Play");
    }

    public void ButtonClickInstrucciones()
    {
        //Codigo que cambia de escena
        //SceneManager.LoadScene("Nombre", LoadSceneMode.Additive);
        Debug.Log("Instrucciones");
    }
    
    public void ButtonClickVideo()
    {
        //Codigo que cambia de escena
        SceneManager.LoadScene("video360", LoadSceneMode.Single);
        //Debug.Log("Video");
    }

    public void ButtonClickClose()
    {
        //Codigo que cierra el juego
        Debug.Log("Close");
        Application.Quit();
    }
}
