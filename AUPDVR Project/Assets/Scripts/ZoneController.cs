using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZoneController : MonoBehaviour
{
    //Serialized Field variables
    [SerializeField] ButtonListener trigger;
    [SerializeField] int mode; //0 = pistol, 1 = taser

    //Non Serialized Field variables
    [SerializeField] public GameObject weapon;
    private bool inZone = false;
    private bool hasGun = false;


    // Start is called before the first frame update
    void Start()
    {
        DropWeapon();
        hasGun = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inZone && !hasGun) 
        {
            if (trigger.isPressed == true) 
            {
                weapon.SetActive(true);
                hasGun = true;
            }
        }

        if (!inZone && hasGun) 
        {
            if (trigger.isPressed == false) 
            {
                DropWeapon();
                hasGun = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {

        if (mode == 0 && other.gameObject.transform.parent.parent.gameObject.name == "HandColliderRight(Clone)") 
        {
            inZone = true;
        }
        else if(mode == 1 && other.gameObject.transform.parent.parent.gameObject.name == "HandColliderLeft(Clone)") 
        {
            inZone = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.transform.parent.parent.gameObject.name == "HandColliderRight(Clone)" || other.gameObject.transform.parent.parent.gameObject.name == "HandColliderLeft(Clone)")
        {
            inZone = false;
        }
    }

    public void DropWeapon() 
    {
        weapon.SetActive(false);
    }
}
