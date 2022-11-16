using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFloorRand : MonoBehaviour
{

    int rand;
    // Start is called before the first frame update
    void Start()
    {
        //Random.seed = System.DateTime.Now.Millisecond;
        rand = Random.Range(1, 3);
        Debug.Log(rand);
    }

    // Update is called once per frame
    public bool destroyThis()
    {
        if(rand == 1)
        {
            Debug.Log("Destroy this");
            return true;
        }
        else
        {
            return false;
        }
    }
}
