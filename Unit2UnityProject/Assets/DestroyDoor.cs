using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {


        //GameObject stl = GameObject.Find("ColorChange");
        //ObjectColorChanger cc = stl.GetComponent<ObjectColorChanger>();

        //GameObject stm = GameObject.Find("ColorChange2");
        //ObjectColorChanger cc2 = stm.GetComponent<ObjectColorChanger>();

        //GameObject str = GameObject.Find("ColorChange3");
        //ObjectColorChanger cc3 = str.GetComponent<ObjectColorChanger>();

        //GameObject sml = GameObject.Find("ColorChange4");
        //ObjectColorChanger cc4 = sml.GetComponent<ObjectColorChanger>();

        //GameObject smm = GameObject.Find("ColorChange5");
        //ObjectColorChanger cc5 = smm.GetComponent<ObjectColorChanger>();

        //GameObject smr = GameObject.Find("ColorChange6");
        //ObjectColorChanger cc6 = smr.GetComponent<ObjectColorChanger>();

        //GameObject sbl = GameObject.Find("ColorChange7");
        //ObjectColorChanger cc7 = sbl.GetComponent<ObjectColorChanger>();

        //GameObject sbm = GameObject.Find("ColorChange8");
        //ObjectColorChanger cc8 = sbm.GetComponent<ObjectColorChanger>();

        //GameObject sbr = GameObject.Find("ColorChange9");
        //ObjectColorChanger cc9 = sbr.GetComponent<ObjectColorChanger>();

        if (blue && blue2 && blue3 && blue4 && blue5 && blue6 && blue7 && blue8 && blue9)
        {
            Debug.Log("Destroy this");
            //Destroy(this);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
