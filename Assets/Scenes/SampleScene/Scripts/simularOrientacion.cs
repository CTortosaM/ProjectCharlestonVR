using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simularOrientacion : MonoBehaviour
{
    // Start is called before the first frame update
    private float yaw;
    private float pitch;
    public float speed = 80;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        pitch = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Rotate(new Vector3(pitch, 0, 0), Space.Self);
        transform.parent.Rotate(new Vector3(0, yaw, 0), Space.Self);
    }
}
