using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilityBelt : MonoBehaviour
{
    [SerializeField] GameObject left_hand;
    [SerializeField] GameObject right_hand;
    [SerializeField] GameObject belt;
    [SerializeField] GameObject cameraObj;

    private Vector3 _avgForwardVector = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateAvgForwardVector();
        belt.transform.forward = avgForwardVector;
        transform.position = new Vector3(cameraObj.GetComponent<Camera>().transform.position.x, transform.position.y, cameraObj.GetComponent<Camera>().transform.position.z);
    }

    public Vector3 avgForwardVector 
    {
        get { return _avgForwardVector; }
    }

    //optimize to only take into account the x and z axis
    private void CalculateAvgForwardVector() 
    {
        float x = (left_hand.transform.forward.x + right_hand.transform.forward.x) / 2;
        float y = (left_hand.transform.forward.y + right_hand.transform.forward.y) / 2;
        float z = (left_hand.transform.forward.z + right_hand.transform.forward.z) / 2;

        _avgForwardVector.x = x;
        _avgForwardVector.y = transform.forward.y;
        _avgForwardVector.z = z;


    }
}