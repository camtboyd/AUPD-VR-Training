using UnityEngine;

public class TeleportationScript : MonoBehaviour
{
    //is SetActive default true?
    [SerializeField] private GameObject[] floorSections; //Assuming index follows "elements" in Unity under "Floor"

    int currentFloor = 0;

    // Start is called before the first frame update
    void Start()
    {
        RayLogic();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void RayLogic()
    {

        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hitData; //saving the game object that was hit
        Physics.Raycast(ray, out hitData);

        /*
         if (hitData.collider.gameObject.tag == "floor") {
              Debug.Log("Hit");
              GameObject o = hitData.collider.gameObject;
              currentFloor = o.GetComponent<FloorProperties>().floorID;
         }
        */

        //while door is open
        {
            if (hitData.collider.GetComponent<FloorProperties>().floorID == 0)
            {
                Debug.Log("Bathroom Area");
                floorSections[2].SetActive(false); //Bedroom panel off
            }
            else if (hitData.collider.GetComponent<FloorProperties>().floorID == 1)
            {
                Debug.Log("Common Space");
                //All floor panels can stay on 
            }
            else if (hitData.collider.GetComponent<FloorProperties>().floorID == 2)
            {
                Debug.Log("BedRoom Area");
                floorSections[0].SetActive(false); //Turn off bathroom panel 
            }
        }

        //While the door is closed
        {
            if (hitData.collider.GetComponent<FloorProperties>().floorID == 0)
            {
                Debug.Log("Bathroom Area");
                floorSections[2].SetActive(false); //Turn off bedroom panel 
            }
            else if (hitData.collider.GetComponent<FloorProperties>().floorID == 1)
            {
                Debug.Log("Common Space");
                floorSections[2].SetActive(false); //Turn off bedroom panel
            }
        }
    }
}

