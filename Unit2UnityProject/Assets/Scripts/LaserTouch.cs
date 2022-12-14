using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTouch : MonoBehaviour
{
    bool checkpoint1 = true;
    bool checkpoint2 = false;
    bool checkpoint3 = false;
    bool checkpoint4 = false;
    bool checkpoint5 = false;
    public GameObject warpPoint;

    void Update() {

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Laser")
        {
            if(checkpoint1 && !checkpoint2) {
                warpPoint = GameObject.Find("Original Checkpoint");
            }
            else if(checkpoint2 && !checkpoint3) {
                warpPoint = GameObject.Find("Checkpoint2");
            }
            else if(checkpoint3 && !checkpoint4) {
                warpPoint = GameObject.Find("Checkpoint3");
            }
            else if(checkpoint4 && !checkpoint5) {
                warpPoint = GameObject.Find("Checkpoint4");
            }
            else if(checkpoint5) {
                warpPoint = GameObject.Find("Checkpoint5");
            }
            
            CharacterController controller = GetComponent<CharacterController>();

            if (controller != null)
            {
                Debug.Log("Teleport");
                controller.enabled = false;
                controller.transform.position = warpPoint.transform.position;
                controller.enabled = true;
            }
        }

        if(hit.gameObject.tag == "Checkpoint2") {
            checkpoint2 = true;
        }
        else if(hit.gameObject.tag == "Checkpoint3") {
            checkpoint3 = true;

        }
        else if(hit.gameObject.tag == "Checkpoint4") {
            checkpoint4 = true;
        }
        else if(hit.gameObject.tag == "Checkpoint5") {
            checkpoint5 = true;
        }
        else {
            checkpoint1 = true;
        }
    }
}
