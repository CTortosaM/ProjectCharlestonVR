using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Audio;

public class Proyector : MonoBehaviour
{
    [SerializeField] private AudioClip proyectorEnMarchaAudio;
    [SerializeField] private AudioClip proyectorSeParaAudio;
    private Animator animator;
    private AudioSource audioSource;

    [SerializeField] private bool estaEncendido = true;

    public bool EstaEncendido { get => estaEncendido;}
    public UnityEvent seHaApagadoElProyector;

    // Start is called before the first frame update

    void Awake () {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        seHaApagadoElProyector.AddListener(seApaga);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Apagar() {
        estaEncendido = false;
        this.animator.Play("Apagarse");

        this.audioSource.Stop();
        this.audioSource.clip = proyectorSeParaAudio;
        this.audioSource.loop = false;
        this.audioSource.Play();


        StartCoroutine("AnunciarApagado");
    }

    private IEnumerator AnunciarApagado() {
        yield return new WaitForSeconds(2);

        seHaApagadoElProyector.Invoke();
    }

    private void seApaga() {
        Debug.Log("Se ha apagado el proyector");
    }
}
