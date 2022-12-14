using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ZoneCalibrator : MonoBehaviour
{
    [SerializeField] private SteamVR_Action_Boolean grabAction;
    [SerializeField] private SteamVR_Input_Sources handType;
    [SerializeField] private GameObject[] zones; //0 pistol, 1 taser
    [SerializeField] private GameObject[] spots; //0 pistol, 1 taser
    [SerializeField] private GameObject LeftHand;
    [SerializeField] private GameObject RightHand;

    // Start is called before the first frame update
    void Start()
    {
        grabAction.AddOnStateDownListener(AButtonDown, handType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AButtonDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) 
    {
        Debug.Log("Pressed A button...");

        zones[0].transform.position = RightHand.transform.position;
        zones[1].transform.position = LeftHand.transform.position;

        spots[0].transform.position = RightHand.transform.position;
        spots[1].transform.position = LeftHand.transform.position;

        zones[0].GetComponent<ZoneController>().DropWeapon(true);
        zones[1].GetComponent<ZoneController>().DropWeapon(true);
    }
}
