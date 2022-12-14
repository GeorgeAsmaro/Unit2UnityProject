using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLevelScript2 : MonoBehaviour
{
    GameObject scriptRunner;
    bool button4Pressed = false;
    bool botFloorTouched = false;
    // Start is called before the first frame update
    public void OnControllerColliderHit(ControllerColliderHit hit) {
        if(hit.gameObject.tag == "button4") {
            button4Pressed = true;
        }
        if(hit.gameObject.tag != "button4") {
            button4Pressed = false;
        }
        if(hit.gameObject.tag == "BottomFloorPod") {
            botFloorTouched = true;
        }
        if(hit.gameObject.tag != "BottomFloorPod") {
            botFloorTouched = false;
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
        if(botFloorTouched) {
            scriptRunner.GetComponent<ThirdLevelScript>().setBotFloorPod(true);
        }
        if(!botFloorTouched) {
            scriptRunner.GetComponent<ThirdLevelScript>().setBotFloorPod(false);
        }
    }
}
