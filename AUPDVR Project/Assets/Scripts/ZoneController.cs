using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneController : MonoBehaviour
{
    [SerializeField] private GameObject Spot;
    [SerializeField] private GameObject Weapon;
    [SerializeField] ButtonListener triggerLeft;
    [SerializeField] ButtonListener triggerRight;
    [SerializeField] GameObject LeftHand;
    [SerializeField] GameObject RightHand;
    [SerializeField] GameObject Belt;

    private bool grabbing = false;
    private int hand = 0; //0 = left, 1 = right


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(grabbing) 
        {
            if(hand == 0) 
            {
                if (triggerLeft.isPressed == false)
                    DropWeapon(false);
            } 
            else 
            {
                if (triggerRight.isPressed == false)
                    DropWeapon(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (grabbing) 
        {
            DropWeapon(true);
        } 
        else 
        {
            if ((other.gameObject.tag == "hand") && (triggerLeft.isPressed == true)) {
                Weapon.transform.parent = LeftHand.transform;
                hand = 0;
                grabbing = true;
            } else if ((other.gameObject.tag == "hand") && (triggerRight.isPressed == true)) {
                Debug.Log("here");
                Weapon.transform.parent = RightHand.transform;
                hand = 1;
                grabbing = true;
            }
        }
        
    }

    private void DropWeapon(bool b) 
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
        grabbing = false;
    }
}
