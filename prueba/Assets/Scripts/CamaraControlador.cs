using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControlador : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform personaje;

    private float tamanioCamara;
    private float alturaPantalla;

    void Start()
    {
        tamanioCamara = Camera.main.orthographicSize;
        alturaPantalla = tamanioCamara * 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
