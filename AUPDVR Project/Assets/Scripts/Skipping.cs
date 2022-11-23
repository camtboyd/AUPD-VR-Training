using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skipping : MonoBehaviour
{

        [SerializeField] GameObject SceneChanger;
        [SerializeField] ButtonListener triggerLeft;
        [SerializeField] ButtonListener triggerRight;

        private void OnTriggerEnter(Collider other) {
            if ((other.gameObject.tag == "hand") && (triggerLeft.isPressed == true) || (triggerRight.isPressed == true)) 
            {
                SceneChanger.GetComponent<SceneChange>().GameScene();
                Debug.Log("Scene Change");
            }
        }
}
