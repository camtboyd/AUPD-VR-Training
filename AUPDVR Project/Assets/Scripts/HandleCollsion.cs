using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollsion : MonoBehaviour
{


    [SerializeField] GameObject door;
    [SerializeField] ButtonListener triggerLeft;
    [SerializeField] ButtonListener triggerRight;

    private bool InZone = false;


    private void OnEnable() 
    {
        //SceneChange.OnChange += SetVars();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
    }

    void SetVars() 
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        InZone = true;
        
    }

    private void OnTriggerExit(Collider other) 
    {
        InZone = false;
    }

    private void OpenDoor() 
    {
        if (!InZone) { return; }

        if ((triggerLeft.isPressed == true) || (triggerRight.isPressed == true)) 
        {
            door.GetComponent<DoorInteraction>().OpenDoor();
        }
    }
}
