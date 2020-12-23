using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtonClick()
    {
        //Codigo que cambia de escena
        //SceneManager.LoadScene("Nombre", LoadSceneMode.Single);
        Debug.Log("Play");
    }

    public void InstruccionesButtonClick()
    {
        //Codigo que cambia de escena
        //SceneManager.LoadScene("Nombre", LoadSceneMode.Additive);
        Debug.Log("Instrucciones");
    }
    
    public void VideoButtonClick()
    {
        //Codigo que cambia de escena
        //SceneManager.LoadScene("Nombre", LoadSceneMode.Single);
        Debug.Log("Video");
    }

    public void CloseButtonClick()
    {
        //Codigo que cierra el juego
        Debug.Log("Close");
        Application.Quit();
    }
}
