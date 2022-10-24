using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    bool blue = false;
    bool continues = true;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag == "ColorChange" && !blue)
        {
            hit.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 0f);
            blue = true;
        }

        if(hit.gameObject.tag == "ColorChange" && blue)
        {
            hit.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
            blue = false;
        }
    }

}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ObjectColorChanger : MonoBehaviour
//{
//    //private Color renderer;


//    private void OnControllerColliderHit(ControllerColliderHit hit)
//    {
//        //renderer = GetComponent<Renderer>;
//        if (hit.gameObject.tag == "ColorChange")
//        {
//            Color blueColour = new Color(0f, 0f, 1f, 0f);
//            hit.gameObject.GetComponent<Renderer>().material.color = blueColour;
//            //GameObject.Find("Square1").GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 0f);
//            Debug.Log("Hit");
//        }
//    }


//}

