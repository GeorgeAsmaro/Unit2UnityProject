using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorChanger : MonoBehaviour
{
    bool blue = false;
    float timer = 0.01f;
    bool timerOn = false;

    private void Update() {
        if(timerOn) {
            timer -= Time.deltaTime;
        }
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag == "ColorChange" && !blue) {
            if(timer < 0) {
                hit.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, 1f);
                hit.gameObject.GetComponent<CheckBlue>().setResults(true);
                blue = true;
                timerOn = false;
                timer = 0.01f;
            }
            
        }

        else if (hit.gameObject.tag == "ColorChange" && blue) {
            if(timer < 0) {
                hit.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
                hit.gameObject.GetComponent<CheckBlue>().setResults(false);
                blue = false;
                timerOn = false;
                timer = 0.01f;
            }
        }

        else {
            timerOn = true;
        }

    }

    



}


