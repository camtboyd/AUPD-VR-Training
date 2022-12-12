using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    [SerializeField] private GameObject[] objects;

    int cuurentFloor = 0;


    // Start is called before the first frame update
    void Start()
    {
        RayLogic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RayLogic() {

        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hitData;
        Physics.Raycast(ray, out hitData);

        if (hitData.collider.gameObject.tag == "floor") {
            GameObject o = hitData.collider.gameObject;
            //currentFloor = o.GetComponent<FloorProperties>().FloorID


        }
    }
}
