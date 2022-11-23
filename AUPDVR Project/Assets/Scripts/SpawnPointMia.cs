using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointMia : MonoBehaviour {
	[SerializeField] private GameObject[] spawnPoint1;
	[SerializeField] private GameObject[] spawnPoint2;
	bool flag = true;
	// Start is called before the first frame update
	void Start() 
	{
		int randomObject = Random.Range(0, spawnPoint1.Length);
		//spawnPoint1[randomObject].SetActive(true);

		int randomObject2 = Random.Range(0, spawnPoint2.Length);
		//spawnPoint2[randomObject2].SetActive(true);

        while (flag) 
		{
			if(randomObject != randomObject2) {
				spawnPoint1[randomObject].SetActive(true);
				spawnPoint2[randomObject2].SetActive(true);
				flag = false;
			}
			else
			randomObject = Random.Range(0, spawnPoint1.Length);
			randomObject2 = Random.Range(0, spawnPoint2.Length);
		}
	}
}

