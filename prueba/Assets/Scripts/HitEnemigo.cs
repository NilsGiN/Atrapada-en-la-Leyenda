﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            GameManager.Instance.PerderVida();
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
