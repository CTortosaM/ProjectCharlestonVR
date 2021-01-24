using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicaPortal : MonoBehaviour
{
    public Canvas fundidoABlancoCanvas;
    public GameObject cuadradoFundido;

    // Start is called before the first frame update
    void Start()
    {
        //cuadradoFundido = fundidoABlancoCanvas.GetComponentInChildren<Color>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        fundidoABlancoCanvas.gameObject.SetActive(true);
        StartCoroutine(FundidoABlanco());
    }


    public IEnumerator FundidoABlanco()
    {
        int fadeSpeed = 1;
        Color objectColor = cuadradoFundido.GetComponent<Image>().color;
        float fadeAmount;
        while (cuadradoFundido.GetComponent<Image>().color.a < 1)
        {
            fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            cuadradoFundido.GetComponent<Image>().color = objectColor;
            yield return null;

        }

        fundidoABlancoCanvas.gameObject.SetActive(false);
        cuadradoFundido.GetComponent<Image>().color = new Color(objectColor.r, objectColor.g, objectColor.b, 0);
        if (fundidoABlancoCanvas.gameObject.activeSelf == false)
        {
            SceneManager.LoadScene("MenuPrincipal");
            yield return null;
        }

    }

}
