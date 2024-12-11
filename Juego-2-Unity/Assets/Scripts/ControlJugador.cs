using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour {
	public float desplazamientoHorizontal;
	public float velocidad = 10.0f;
	public float rangoX = 20.0f;
	public GameObject proyectilPrefab;
	public GameObject proyectil2Prefab;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)){
			// Lanzamiento de chuleta
			Debug.Log("Lanzamiento principal");
			Instantiate(proyectilPrefab, transform.position, proyectilPrefab.transform.rotation);
		}
		if (Input.GetKeyDown(KeyCode.Return))
		{
			// Lanzamiento de galleta
			Debug.Log("Lanzamiento alternativo");

			Instantiate(proyectil2Prefab, transform.position, proyectil2Prefab.transform.rotation);
		}

		// Keep the player in bounds
		if (transform.position.x < -rangoX){
			transform.position = new Vector3(-rangoX, transform.position.y, transform.position.z);
		}
		if (transform.position.x > rangoX){
			transform.position = new Vector3(rangoX, transform.position.y, transform.position.z);
		}

		desplazamientoHorizontal = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * desplazamientoHorizontal * Time.deltaTime * velocidad);
	}
}
