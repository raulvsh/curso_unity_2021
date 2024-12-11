using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroHelice : MonoBehaviour
{
    //public GameObject helice;
    public float rotationSpeed = 800;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed);

        //transform.Rotate(Vector3.left * Time.deltaTime );

    }
}
