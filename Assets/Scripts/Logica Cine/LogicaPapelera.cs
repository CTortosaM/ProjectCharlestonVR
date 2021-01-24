using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaPapelera : MonoBehaviour
{
    public Text textoContador;
    private int _contador;

    public GameObject proyector;
    public GameObject robotRustCore;


    // Start is called before the first frame update
    void Start()
    {
       // textoContador = GetComponentInChildren<Text>();
        _contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EasterEgg"))
        {
            //Cambiar proyector
            proyector.SetActive(false);
            robotRustCore.SetActive(true);
        }
        else if (other.CompareTag("Mano")) 
        {
        }
        else if (other.CompareTag("NoTriggerPapelera"))
        {
        }
        else
        {
            //Añadir a contador papelera
            print("+1");
            _contador += 1;
            textoContador.text = _contador.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("EasterEgg"))
        {
            //Descambiar el proyector
            proyector.SetActive(true);
            robotRustCore.SetActive(false);

        }
        else if (other.CompareTag("Mano"))
        {
        }
        else if (other.CompareTag("NoTriggerPapelera"))
        {
        }
        else
        {
            //Descontar contador papelera en -1
            print("-1");
            _contador -= 1;
            textoContador.text = _contador.ToString();
        }
    }
}
