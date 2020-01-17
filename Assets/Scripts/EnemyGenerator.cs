using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	public GameObject Enemy1;

	public float spawnRate = 2f;

	public float nextSpawn = 0f;

	int whatToSpawn;

	// Use this for initialization
	void Start () {

		transform.localPosition = new Vector3 (0f, 28f, 0f);
		StartCoroutine (Center ());

	}

	// Update is called once per frame
	void Update () 
	{
		if (Time.time > nextSpawn) 
		{
			whatToSpawn = Random.Range (1, 3);
			Debug.Log (whatToSpawn);

			switch (whatToSpawn) {

			case 1:
				Instantiate (Enemy1, transform.position, Quaternion.identity);	
				//			case 2:
				//				Instantiate( coin1, spawnPosition.x+5f, Quaternion.identity );
				//			case 3:
				//				Instantiate( coin1, spawnPosition.x-5f, Quaternion.identity );
				break;
			}
			nextSpawn = Time.time + spawnRate;
		}
	}

	IEnumerator RightMove()
	{
		yield return new WaitForSeconds(1f);
		transform.localPosition = new Vector3(4.0f, 28f, 0f);
		transform.rotation = Quaternion.identity;
		StartCoroutine (LeftMove ());
	}

	IEnumerator LeftMove()
	{
		yield return new WaitForSeconds (1f);
		transform.localPosition = new Vector3(-7.0f, 28f, 0);
		transform.rotation = Quaternion.identity;
		StartCoroutine (Center ());
	}

	IEnumerator Center()
	{
		yield return new WaitForSeconds (1f);
		transform.localPosition = new Vector3(0.0f, 28f, 0.0f);
		transform.rotation = Quaternion.identity;
		StartCoroutine (RightMove ());
	}


}
