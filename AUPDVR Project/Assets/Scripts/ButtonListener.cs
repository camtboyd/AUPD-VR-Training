using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ButtonListener : MonoBehaviour {
    public SteamVR_Action_Boolean grabAction;
    public SteamVR_Input_Sources handType;
    public bool isPressed;


    void Awake() {

    }

    // Start is called before the first frame update
    void Start() 
    {
        grabAction.AddOnStateDownListener(TriggerDown, handType);
        grabAction.AddOnStateUpListener(TriggerUp, handType);
    }


    // Update is called once per frame
    void Update() 
    {
        
    }


    private void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) {
        isPressed = false;
    }

    private void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource) {
        isPressed = true;
    }

}
