using UnityEngine;
using System.Collections;

public class SpawnItems : MonoBehaviour {

	public Transform[] SpawnPoints;
	public float spawnTime = 1.5f;
	public GameObject PickUps;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnPickUps", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		//InvokeRepeating ("Pick Up", spawnTime, spawnTime);
	}

	void SpawnPickUps(){
		int spawnIndex = Random.Range (0, SpawnPoints.Length);
		Instantiate(PickUps, SpawnPoints [spawnIndex].position, SpawnPoints [spawnIndex].rotation);
	}
}
