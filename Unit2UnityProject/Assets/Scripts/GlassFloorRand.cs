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
    }

    // Update is called once per frame
    public bool destroyThis()
    {
        if(rand == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
