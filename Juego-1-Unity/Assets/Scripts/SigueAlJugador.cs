﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigueAlJugador : MonoBehaviour
{
    public GameObject Jugador;

    private Vector3 Desplazamiento = new Vector3(0,6,-9);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position + Desplazamiento;
    }
}
