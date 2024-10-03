using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovimiento : MonoBehaviour
{
    // Start is called before the first frame update
    float mouseposX;
    float mouseposY;
    public float cantmovimiento;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseposX = Input.mousePosition.x;
        mouseposY = Input.mousePosition.y;

        this.GetComponent<RectTransform>().position = new Vector2((mouseposX / Screen.width) * cantmovimiento + (Screen.width / 2), (mouseposY / Screen.height) * cantmovimiento + (Screen.height / 2));
    }
}
