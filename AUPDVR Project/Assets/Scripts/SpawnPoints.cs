using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour 
{
    [SerializeField] private GameObject[] points;
    [SerializeField] private GameObject[] weaponsPerfabs;
    [SerializeField] private List<GameObject> weaponsSpawned;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SpawnWeapons() 
    {
        RandomPointsArray();

        for(int i = 0; i < 5; i++) 
        {
            GameObject o = Instantiate(weaponsPerfabs[i]);
            o.transform.position = points[i].transform.position;
            o.GetComponent<RoateBehavior>().RotateObject(points[i].transform.rotation);
            weaponsSpawned.Add(o);
        }
    }

    private void RandomPointsArray() 
    {
        
        for(int i = 0; i < points.Length; i++) 
        {
            GameObject temp = points[i];
            int rand = Random.Range(0, points.Length);
            points[i] = points[rand];
            points[rand] = temp;
        }
    }
}
