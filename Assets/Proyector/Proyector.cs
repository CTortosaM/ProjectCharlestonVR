using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Proyector : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private bool estaEncendido = true;

    public bool EstaEncendido { get => estaEncendido;}
    public UnityEvent seHaApagadoElProyector;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        seHaApagadoElProyector.AddListener(seApaga);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Apagar() {
        estaEncendido = false;
        this.animator.Play("Apagarse");

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
