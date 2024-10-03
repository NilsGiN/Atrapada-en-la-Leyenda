using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HUD : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI puntos;
    public GameObject[] vidas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = "Puntaje: " + GameManager.Instance.PuntosTotales.ToString(); 
    }

    public void ActualizarPuntos(int puntosTotales)
    {
        puntos.text = puntosTotales.ToString();
    }

    public void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }

    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
