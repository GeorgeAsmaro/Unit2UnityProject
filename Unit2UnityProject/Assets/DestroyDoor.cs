using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        bool destroyed = false;

        if(!destroyed)
        {
            GameObject stl = GameObject.Find("TopLeft");
            bool blue = stl.GetComponent<CheckBlue>().getResults();

            GameObject stm = GameObject.Find("TopMiddle");
            bool blue2 = stm.GetComponent<CheckBlue>().getResults();

            GameObject str = GameObject.Find("TopRight");
            bool blue3 = str.GetComponent<CheckBlue>().getResults();

            GameObject sml = GameObject.Find("MidLeft");
            bool blue4 = sml.GetComponent<CheckBlue>().getResults();

            GameObject smm = GameObject.Find("Middle");
            bool blue5 = smm.GetComponent<CheckBlue>().getResults();

            GameObject smr = GameObject.Find("MidRight");
            bool blue6 = smr.GetComponent<CheckBlue>().getResults();

            GameObject sbl = GameObject.Find("BottomLeft");
            bool blue7 = sbl.GetComponent<CheckBlue>().getResults();

            GameObject sbm = GameObject.Find("BottomMiddle");
            bool blue8 = sbm.GetComponent<CheckBlue>().getResults();

            GameObject sbr = GameObject.Find("BottomRight");
            bool blue9 = sbr.GetComponent<CheckBlue>().getResults();

            if (blue && !blue2)
            {
                Debug.Log("Destroy this");
                //Destroy(this);
                destroyed = true;
            }
        }
        
    }

}
