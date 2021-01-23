using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarTambor : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mano"))
        {
            switch (Random.Range(0, 3))
            {
                case 0:
                    audioSource.Play();
                    break;
                case 1:
                    audioSource2.Play();
                    break;
                case 2:
                    audioSource3.Play();
                    break;
                default:
                    audioSource.Play();
                    break;
            }
        }
    }
}
