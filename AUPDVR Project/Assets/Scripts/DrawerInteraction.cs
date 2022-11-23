using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerInteraction : MonoBehaviour 
{
    [SerializeField] private GameObject drawer;
    private bool DrawerOpen = false;


    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OpenDrawer() {
        if (DrawerOpen)
            return;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + -.3f);
        DrawerOpen = true;
    }
}



