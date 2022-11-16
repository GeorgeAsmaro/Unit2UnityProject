using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2SpawnChange : MonoBehaviour
{

    private Animation checkpointchange;
    private Animation checkpointchange2;
    public GameObject checkPointmover;

    bool changed = false;
    bool changed2 = false;
    // Start is called before the first frame update
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        checkpointchange = checkPointmover.GetComponent<Animation>();
        checkpointchange2 = checkPointmover.GetComponent<Animation>();
        if (hit.gameObject.tag == "CheckPoint")
        {
            
            if(!changed)
            {
                Debug.Log("touched");
                checkpointchange.Play("lvl2spawnChange1");
                Debug.Log("change spawn");
                changed = true;
            }
            
        }

        if(hit.gameObject.tag == "Checkpoint2")
        {
            
            if (changed && !changed2)
            {
                Debug.Log("touched");
                checkpointchange.Play("lvl2spawnChange2");
                Debug.Log("change spawn again");
                changed2 = true;
            }
        }
        
    }
}
