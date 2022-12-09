using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLevelScript2 : MonoBehaviour
{
    GameObject scriptRunner;
    bool button4Pressed = false;
    // Start is called before the first frame update
    public void OnControllerColliderHit(ControllerColliderHit hit) {
        while(hit.gameObject.tag == "button4") {
            button4Pressed = true;
        }
        while(hit.gameObject.tag != "button4") {
            button4Pressed = false;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        GameObject scriptRunner = GameObject.Find("ScriptRunner");

        if(button4Pressed) {
            scriptRunner.GetComponent<ThirdLevelScript>().setButton4Pressed(true);
        }
        if(!button4Pressed) {
            button4Pressed = scriptRunner.GetComponent<ThirdLevelScript>().setButton4Pressed(false);
        }
    }
}
