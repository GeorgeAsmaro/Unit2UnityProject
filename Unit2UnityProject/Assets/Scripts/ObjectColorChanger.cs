using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    bool blue = false;
    bool sleep = false;
    bool changeable = true;
    float timer = 300;


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        timer += Time.deltaTime;

        if (hit.gameObject.tag == "ColorChange" && !blue && changeable)
        {
            hit.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 0f);
           // Debug.Log("Blue is true");
            blue = true;
            changeable = false;
        }

        if(!changeable)
        {
            timer--;

            if(timer <=0)
            {   
             
                Debug.Log("Timer finished");
                timer = 300;
                changeable = true;
            }
        }


        if (hit.gameObject.tag == "ColorChange" && blue && changeable)
        {
            hit.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
            //Debug.Log("Blue is false");
            blue = false;
            changeable = false;
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

