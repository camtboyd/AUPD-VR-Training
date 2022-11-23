using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipScene : MonoBehaviour
{
    
    [SerializeField] GameObject cube;
    [SerializeField] ButtonListener triggerLeft;
    [SerializeField] ButtonListener triggerRight;

    private void OnTriggerEnter(Collider other) {
        if ((other.gameObject.tag == "hand") && (triggerLeft.isPressed == true) || (triggerRight.isPressed == true)) {
            cube.GetComponent<SceneChange>().GameScene();
            Debug.Log("Skipping");
        }
    }
}

