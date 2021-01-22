using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;

public class Pull : MonoBehaviour
{
    public GameObject player;
    public GameObject controller;
    public Vector3 prevPos;
    public bool bCanGrip;

     void Update()
    {
        prevPos = controller.transform.localPosition;
    }
    public void setPos()
    {
        if (bCanGrip )
        {
            player.transform.position += (prevPos - controller.transform.localPosition);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == 9) {
            bCanGrip = true; //trepa sobre cualquier elemento con collider del escenario

        }
        //si se quiere designar ciertos elementos como "trepables", crear un Layer nuevo, por ejemplo el 9, con nombre trepable
        //asignar dicho layer solo al objeto sobre el que se quiera trepar y por último
        //comentar la línea 26 y descomentar el siguiente código
        //if (other .gameObject .layer == 9)
        //{
        //    bCanGrip = true;
        //}
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9) {
            bCanGrip = false;   

        }
    }
}
