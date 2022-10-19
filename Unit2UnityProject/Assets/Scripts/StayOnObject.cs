using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnObject : MonoBehaviour
{


    private void OnControllerColliderHit(ControllerColliderHit collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {

            this.transform.parent = collision.transform;

        }
        else
        {
            this.transform.parent = null;
        }

    }
    
}