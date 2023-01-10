using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{

    [SerializeField] private GameObject door;
    [SerializeField] private Animator animator;
    public bool IsOpen = false;
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

    /*
    public void OpenDoor() 
    {
        if(Time.time > timer+2f) 
        {
            if (IsOpen) 
            {
                animator.ResetTrigger("ToOpen");
                animator.SetTrigger("ToClose");
                IsOpen = false;
            } 
            else if (!IsOpen) 
            {
                animator.ResetTrigger("ToClose");
                animator.SetTrigger("ToOpen");
                IsOpen = true;
            }
        }        
    }
    */

    public void OpenDoor() {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + -20f);
        IsOpen = true;
    }
}
