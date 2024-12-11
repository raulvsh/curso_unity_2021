using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    float velocidad = 20.0f;
    float velocidadGiro = 25.0f;
    float controlHorizontal;
    float controlAvance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Leemos el sistema de entrada
        controlHorizontal = Input.GetAxis("Horizontal");
        controlAvance = Input.GetAxis("Vertical");

        //Control de velocidad
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * controlAvance);

        //Control de giro
        transform.Rotate(Vector3.up, Time.deltaTime * velocidadGiro * controlHorizontal);
    }
}
