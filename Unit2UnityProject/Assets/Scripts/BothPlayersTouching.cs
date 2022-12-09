using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BothPlayersTouching : MonoBehaviour
{
    public GameObject scriptRunner;
    bool touching1 = false;
    bool touching2 = false;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        GameObject scriptRunner = GameObject.Find("ScriptRunner");

        
        if(hit.gameObject.tag == "PodFloor" || hit.gameObject.tag == "PodFloor2")
        {
            
            if(!scriptRunner.GetComponent<ThirdLevelScript>().getPart1())
            {
                touching1 = true;
            }

            else if (scriptRunner.GetComponent<ThirdLevelScript>().getPart1())
            {
                touching2 = true;
            }
        }

        if(hit.gameObject.tag == "lvl2") {

        }
    }

    public bool getTouching()
    {
        return touching1;
    }
    
    public bool getTouching2()
    {
        return touching2;
    }
}
