using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorProperties : MonoBehaviour
{
    [SerializeField] public int floorID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetID() {
        return floorID;
    }
}
