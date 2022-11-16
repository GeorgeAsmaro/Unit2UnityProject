using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFloorScript : MonoBehaviour
{

    private MeshRenderer rend;
    private BoxCollider col;
    // Start is called before the first frame update
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "GlassFloor")
        {
            bool destroy = hit.gameObject.GetComponent<GlassFloorRand>().destroyThis();
            rend = hit.gameObject.GetComponent<MeshRenderer>();
            col = hit.gameObject.GetComponent<BoxCollider>();
            if(destroy)
            {
                Destroy(rend);
                Destroy(col);
            }
            else if(!destroy)
            {
                hit.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 1f);
            }
        }
    }
}
