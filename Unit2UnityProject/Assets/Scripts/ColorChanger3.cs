using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger3 : MonoBehaviour
{
    bool blue = false;
    float timer = 0.01f;


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag == "ColorChange3" && !blue) {
            if(timer < 0) {
                hit.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 1f);
                hit.gameObject.GetComponent<CheckBlue>().setResults(true);
                blue = true;
                timer = 0.01f;
            }
            
        }
        else if (hit.gameObject.tag != "ColorChange3" && !blue) {
            timer -= Time.deltaTime;
        }


        if (hit.gameObject.tag == "ColorChange3" && blue) {
            if(timer < 0) {
                hit.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                hit.gameObject.GetComponent<CheckBlue>().setResults(false);
                blue = false;
                timer = 0.01f;
            }
            
        }

        else if (hit.gameObject.tag != "ColorChange3" && blue) {
            timer -= Time.deltaTime;
        }

        

    }

    



}


