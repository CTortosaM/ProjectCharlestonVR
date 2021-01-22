using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastCamera : MonoBehaviour
{
    //public Transform player;
    public float longitud; //del rayo
    //public Animator miraAnim; //no para selección por tiempo, solo para animar un cursor, acutalmente oculto
    //public UnityEngine.UI.Image cursor; //cursor con el progreso
    public float speed = 1.0f;  //velocidad del progreso
    private float currentProgress = 0; // variable para almacenar el progeso del cursor, de 0 a 1
    private GameObject gaze; //objeto para almacenar el objeto tocado

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + transform.forward * longitud, Color.red);
        RaycastHit hit;
        int layerMask = 1 << 10; // máscara, solo los objetos en el layer10 serán detectados
        if (Physics.Raycast(transform.position, transform.forward, out hit, longitud, layerMask))
        {
            if (gaze != hit.transform.gameObject)
            {
                gaze = hit.transform.gameObject;
                //miraAnim.SetTrigger("big"); //animación del cursor oculto
                gaze.SendMessage("m_enter");
                currentProgress = 0;
            }
        }
        else
        {
            if (gaze != null)
            {
                gaze.SendMessage("m_exit");
                //miraAnim.SetTrigger("small"); //animación del cursor oculto
            }
            gaze = null;
            currentProgress = 0;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            sendClick();
        }

        //manageCursor(); //progreso del cursor y click
        sendClick();
    }

    public void sendClick()
    {
        if (gaze != null)
        {
            gaze.SendMessage("m_click");
        }
    }

    private void manageCursor()
    {
        if (gaze != null)
        {
            if (currentProgress < 1)
            {

                currentProgress += speed * Time.deltaTime;
                //cursor.fillAmount = currentProgress;
            }
            else
            {
                if (currentProgress != 1)
                {
                    currentProgress = 1;
                    sendClick();
                }

            }

        }
        else
        {
            currentProgress = 0;
            //cursor.fillAmount = currentProgress;
        }
    }
}
