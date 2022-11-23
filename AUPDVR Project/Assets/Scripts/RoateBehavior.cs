using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoateBehavior : MonoBehaviour
{
    [SerializeField] private bool X;
    [SerializeField] private bool Y;
    [SerializeField] private bool Z;

    [SerializeField] Transform t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateObject(Quaternion q) 
    {
        if(X)
        {
            t.rotation = new Quaternion(t.rotation.x, t.rotation.y, t.rotation.z, t.rotation.w);
        }
        else if(Y) 
        {
            t.rotation = new Quaternion(t.rotation.x, t.rotation.y , t.rotation.z, t.rotation.w);
        }
        else 
        {
            t.rotation = new Quaternion(t.rotation.x, t.rotation.y, t.rotation.z, t.rotation.w);
        }
    }
}
