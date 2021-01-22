using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPapelera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ficha_Senet"))
        {
            //Cambiar proyector
            print("Trigger papelera");
        }
        else
        {
            //Añadir a contador papelera
            print("+1");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ficha_Senet"))
        {
            //Descambiar el proyector
            print("DesTrigger papelera");
        }
        else
        {
            //Descontar contador papelera en -1
            print("-1");
        }
    }
}
