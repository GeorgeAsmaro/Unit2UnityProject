using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    bool blue = false;
    bool changeable = true;
    float timer = 100f;


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        timer += Time.deltaTime;

        if ((hit.gameObject.tag == "ColorChange" || hit.gameObject.tag == "ColorChange2" || hit.gameObject.tag == "ColorChange3" || hit.gameObject.tag == "ColorChange4" || hit.gameObject.tag == "ColorChange5" || hit.gameObject.tag == "ColorChange6" || hit.gameObject.tag == "ColorChange7" || hit.gameObject.tag == "ColorChange8" || hit.gameObject.tag == "ColorChange9") && !blue && changeable)
        {
            hit.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 1f);
            hit.gameObject.GetComponent<CheckBlue>().setResults(true);
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
                timer = 100f;
                changeable = true;
            }
        }


        if ((hit.gameObject.tag == "ColorChange" || hit.gameObject.tag == "ColorChange2" || hit.gameObject.tag == "ColorChange3" || hit.gameObject.tag == "ColorChange4" || hit.gameObject.tag == "ColorChange5" || hit.gameObject.tag == "ColorChange6" || hit.gameObject.tag == "ColorChange7" || hit.gameObject.tag == "ColorChange8" || hit.gameObject.tag == "ColorChange9") && blue && changeable)
        {
            hit.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
            hit.gameObject.GetComponent<CheckBlue>().setResults(false);
            //Debug.Log("Blue is false");
            blue = false;
            changeable = false;
        }

    }

    



}


