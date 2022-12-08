using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollsion : MonoBehaviour
{


    [SerializeField] GameObject door;
    [SerializeField] ButtonListener triggerLeft;
    [SerializeField] ButtonListener triggerRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        if((other.gameObject.tag == "hand") && (triggerLeft.isPressed == true) || (triggerRight.isPressed == true)) 
        {
            Debug.Log(other.gameObject.tag);
            door.GetComponent<DoorInteraction>().OpenDoor();
            Debug.Log("Opening Door");
        }
    }
}
