using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonEvents : MonoBehaviour
{

    [SerializeField] private GameObject menuPrincipal = null;
    [SerializeField] private GameObject instrucciones = null;
    // Start is called before the first frame update
    public UnityEvent myEvent;  //para definir en el Editor las funciiones a ejecutar en los botones

    void Start() {
        foreach(GameObject go in Resources.FindObjectsOfTypeAll<GameObject>()){
            if (instrucciones && menuPrincipal) {
                return;
            }
            if (go.name == "MenuPrincipal") {
                menuPrincipal = go;
            } 
            else if (go.name =="Instrucciones") {
                instrucciones = go;
            }
        }
    }

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
        menuPrincipal.SetActive(false);
        instrucciones.SetActive(true);
    }
    
    public void ButtonClickVideo()
    {
        //Codigo que cambia de escena
        //SceneManager.LoadScene("Nombre", LoadSceneMode.Single);
        Debug.Log("Video");
    }

    public void ButtonClickClose()
    {
        //Codigo que cierra el juego
        Debug.Log("Close");
        Application.Quit();
    }

    public void ButtonReturnToMenu(){
        Debug.Log("Return to menu");
        menuPrincipal.SetActive(true);
        instrucciones.SetActive(false);
    }
}
