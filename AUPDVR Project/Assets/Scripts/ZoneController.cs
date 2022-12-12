using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZoneController : MonoBehaviour
{
    //Serialized Field variables
    [SerializeField] private GameObject Spot;
    [SerializeField] private GameObject Weapon;
    [SerializeField] ButtonListener triggerLeft;
    [SerializeField] ButtonListener triggerRight;
    [SerializeField] GameObject LeftHand;
    [SerializeField] GameObject RightHand;
    [SerializeField] GameObject Belt;

    //Non Serialized Field variables
    
    private int hand = 0; //0 = right, 1 = left
    private bool inZone = false;
    private bool hasGun = false;
    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inZone && hasGun) 
        {
            if(Time.time < timer + 1f) { return; }

            if (triggerRight.isPressed == false) 
            {
                DropWeapon(true);
                hasGun = false;
                timer = Time.time;
            }
            else if (triggerLeft.isPressed == false) 
            {
                DropWeapon(true);
                hasGun = false;
                timer = Time.time;
            }
        }

        if (inZone && !hasGun) 
        {
            if (Time.time < timer + 1f) { return; }

            if (triggerRight.isPressed == true && hand == 0) 
            {
                Weapon.transform.parent = RightHand.transform;
                hasGun = true;
                timer = Time.time;
            } 
            else if (triggerLeft.isPressed == true && hand == 1) 
            {
                Weapon.transform.parent = LeftHand.transform;
                hasGun = true;
                timer = Time.time;
            } 
        }

        if (!inZone && hasGun) {
            if (Time.time < timer + 1f) { return; }

            if (triggerRight.isPressed == false) 
            {
                DropWeapon(true);
                hasGun = false;
                timer = Time.time;
            }
            else if (triggerLeft.isPressed == false) {
                DropWeapon(true);
                hasGun = false;
                timer = Time.time;
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.transform.parent.parent.gameObject.name == "HandColliderRight(Clone)") 
        {
            hand = 0;
            inZone = true;
        }
        else if(other.gameObject.transform.parent.parent.gameObject.name == "HandColliderLeft(Clone)") 
        {
            hand = 1;
            inZone = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.name == "finger_pinky_2_r") 
        {
            inZone = false;
        }
    }

    public void DropWeapon(bool b) 
    {
        if(b) 
        {
            Weapon.transform.parent = Belt.transform;
            Weapon.transform.position = Spot.transform.position;
            Weapon.transform.rotation = Spot.transform.rotation;
        }
        else 
        {
            Weapon.transform.parent = null;
            Weapon.GetComponent<Rigidbody>().useGravity = true;
        }
    }




}
