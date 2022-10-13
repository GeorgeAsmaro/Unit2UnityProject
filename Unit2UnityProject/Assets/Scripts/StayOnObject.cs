using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnObject : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {

            this.transform.parent = collision.transform;

        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
            this.transform.parent = null;
    }
}