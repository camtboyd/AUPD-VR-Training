using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{

    [SerializeField] private GameObject door;
    //[SerializeField] private Animation doorAni;
    private bool IsOpen = false;


    // Start is called before the first frame update
    void Start()
    {
        //doorAni.wrapMode = WrapMode.Once;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor() 
    {
        Debug.Log("HERE");
        if (IsOpen)
            return;
        Vector3 rotation = new Vector3(0, 0, -115);
        door.transform.Rotate(rotation);
        IsOpen = true;
    }

}
