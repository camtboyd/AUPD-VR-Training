using UnityEngine;



public class TeleportationScript : MonoBehaviour {
    //is SetActive default true?
    [SerializeField] private GameObject[] floorSections; //Assuming index follows "elements" in Unity under "Floor"

    int currentFloor = 0;
    [SerializeField] private GameObject door;

    // Start is called before the first frame update
    void Start() {
    }

    // Problem with collider being on a child object
    private void RayLogic() {

        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hitData; //saving the game object that was hit
        Physics.Raycast(ray, out hitData);
        Debug.DrawRay(transform.position, Vector3.down, Color.yellow);

        Debug.Log(hitData.collider.gameObject.name);

        if (hitData.collider.gameObject.tag == "floor") {
            Debug.Log("Hit");
            currentFloor = hitData.collider.gameObject.GetComponent<FloorProperties>().floorID;
        }
        //Find a different way to do the switch statements without loop 
        // If teleportation is used
    }

    // Update is called once per frame
    void Update() {

        RayLogic();
        return;

        //while door is open
        if (door.GetComponent<DoorInteraction>().IsOpen) //right now, the method to actually open the door has an animator?? Is that giving the measurements to open the door?
        {
            switch (currentFloor) {
                case 0:
                 //   Debug.Log("Bathroom Area");
                    floorSections[0].SetActive(true);
                    floorSections[1].SetActive(true);
                    floorSections[2].SetActive(true);
                    floorSections[3].SetActive(true);
                    floorSections[4].SetActive(true);
                    floorSections[5].SetActive(false); //Bedroom panel off
                    floorSections[6].SetActive(false);
                    floorSections[7].SetActive(false);
                   
                    break;
                case 1:
                  //  Debug.Log("Common Space");
                    //All floor panels can stay on 
                    floorSections[0].SetActive(true);
                    floorSections[1].SetActive(true);
                    floorSections[2].SetActive(true);
                    floorSections[3].SetActive(true);
                    floorSections[4].SetActive(true);
                    floorSections[5].SetActive(true);
                    floorSections[6].SetActive(true);
                    floorSections[7].SetActive(true);
                    break;
                case 2:
                  //  Debug.Log("BedRoom Area");
                    floorSections[0].SetActive(false); //Turn off bathroom panel 
                    floorSections[1].SetActive(false);
                    floorSections[2].SetActive(true);
                    floorSections[3].SetActive(true);
                    floorSections[4].SetActive(true);
                    floorSections[5].SetActive(true);
                    floorSections[6].SetActive(true);
                    floorSections[7].SetActive(true);
                    break;
            }
        }

        //While the door is closed
        if (!door.GetComponent<DoorInteraction>().IsOpen) {
            switch (currentFloor) {
                case 0:
                 //   Debug.Log("Bathroom Area");
                    floorSections[0].SetActive(true);
                    floorSections[1].SetActive(true);
                    floorSections[2].SetActive(true);
                    floorSections[3].SetActive(true);
                    floorSections[4].SetActive(true);
                    floorSections[5].SetActive(false); //Bedroom panel off
                    floorSections[6].SetActive(false);
                    floorSections[7].SetActive(false);
                    break;
                case 1:
                 //   Debug.Log("Common Space");
                    floorSections[0].SetActive(true);
                    floorSections[1].SetActive(true);
                    floorSections[2].SetActive(true);
                    floorSections[3].SetActive(true);
                    floorSections[4].SetActive(true);
                    floorSections[5].SetActive(false); //Bedroom panel off
                    floorSections[6].SetActive(false);
                    floorSections[7].SetActive(false);
                    break;
                case 2:
                 //   Debug.Log("BedRoom Area");
                    floorSections[0].SetActive(false); //Everything is off but bedroom 
                    floorSections[1].SetActive(false);
                    floorSections[2].SetActive(false);
                    floorSections[3].SetActive(false);
                    floorSections[4].SetActive(false);
                    floorSections[5].SetActive(true);
                    floorSections[6].SetActive(true);
                    floorSections[7].SetActive(true);
                    break;
            }
        }
    }

}