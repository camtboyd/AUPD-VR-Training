using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{

    [SerializeField] private GameObject door;
    [SerializeField] private Animator animator;
    private bool IsOpen = false;
    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor() 
    {
        if(Time.time > timer+2f) 
        {
            if (IsOpen) 
            {
                Debug.Log("Closing Door");
                animator.ResetTrigger("ToOpen");
                animator.SetTrigger("ToClose");
                IsOpen = false;
            } 
            else if (!IsOpen) 
            {
                Debug.Log("Opening Door");
                animator.ResetTrigger("ToClose");
                animator.SetTrigger("ToOpen");
                IsOpen = true;
            }
        }
           
        /*
        Vector3 rotation = new Vector3(0, 0, -115);
        door.transform.Rotate(rotation);
        IsOpen = true;
        */
    }

}
