using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {
	public GameObject[] animalesPrefabs;
	private float spawnRangeX = 20;
	private float spawnRangeZ = 30;
	private float startDelay = 2;
	private float spawnInterval = 2.0f;

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("GenerarAnimalAleatorio", startDelay, spawnInterval);
	}

	// Update is called once per frame
	void Update()
	{
   
    }

	void GenerarAnimalAleatorio()
	{
		int indexAnimal = Random.Range(0, animalesPrefabs.Length);
		//Debug.Log(indexAnimal);

		Vector3 posGenerador = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
		//Generar un animal
		Instantiate(animalesPrefabs[indexAnimal], posGenerador, animalesPrefabs[indexAnimal].transform.rotation);
	}
}
