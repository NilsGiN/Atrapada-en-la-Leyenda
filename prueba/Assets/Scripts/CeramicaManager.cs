using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CeramicaManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI nivelFinalizado;
    public TextMeshProUGUI ceramicasTotales;
    public TextMeshProUGUI ceramicasCogidas;

    private int totalCeramicasEnNivel;
    void Start()
    {
        totalCeramicasEnNivel = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        TodasLasFrutasRecolectadas();
        ceramicasTotales.text = totalCeramicasEnNivel.ToString();
        ceramicasCogidas.text = transform.childCount.ToString();
    }

    public void TodasLasFrutasRecolectadas()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("No quedan frutas, victoria");
            nivelFinalizado.gameObject.SetActive(true);
            Invoke("CambiarEscena", 2);
        }  
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
