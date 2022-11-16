using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTouch : MonoBehaviour
{
    public GameObject warpPoint;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Laser")
        {
            CharacterController controller = GetComponent<CharacterController>();

            if (controller != null)
            {
                Debug.Log("Teleport");
                controller.enabled = false;
                controller.transform.position = warpPoint.transform.position;
                controller.enabled = true;
            }
        }
    }
}
