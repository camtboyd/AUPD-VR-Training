using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
    [SerializeField] private GameObject[] spawnPoint1;
    [SerializeField] private GameObject[] spawnPoint2;
    [SerializeField] private GameObject[] spawnPoint3;

    bool flag = true;
    int[] randNum = new int[3] { 0, 1, 2 }; //Numbers that correspond to the weapons
    GameObject[][] arrObj = new GameObject[2][]; //An array of arrays
    bool found = false;
    int spot = 3;
    void Start() 
    {
        Spawn();
    }

    private void Spawn() 
    {
        arrObj[0] = spawnPoint1;
        arrObj[1] = spawnPoint2;
        foreach (GameObject[] array_ in arrObj) //For each array in the array
        {
            foreach (int i in randNum) {
                Debug.Log(i);
            }
            int number = Random.Range(0, spot); //selects random items out of array

            Debug.Log($"Random:{number}");
            foreach (GameObject obj_ in array_) {
                if (randNum[number] == obj_.GetComponent<WeaponProperties>

                ().idNumber) {
                    obj_.SetActive(true);
                }
            }
            //Makes selected item appear

            for (int i = 0; i < randNum.Length; i++) {
                if (!found) {
                    if (number == randNum[i]) {
                        found = true;
                    }
                }
                if (found) {
                    if (i == randNum.Length - 1) {
                        spot--;
                    } else {
                        randNum[i] = randNum[i + 1];
                    }
                }
            }
        }
    }
}