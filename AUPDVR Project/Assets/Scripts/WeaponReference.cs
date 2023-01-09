using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponReference : MonoBehaviour
{
    [SerializeField] private int mode; //0 = pistol, 1 = taser

    // Start is called before the first frame update
    void Start()
    {
        if(mode == 0) 
        {
            GameObject.FindGameObjectWithTag("PistolZone").GetComponent<ZoneController>().weapon = this.gameObject;
        }
        else 
        {
            GameObject.FindGameObjectWithTag("TaserZone").GetComponent<ZoneController>().weapon = this.gameObject;
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
