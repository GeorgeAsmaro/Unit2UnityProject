using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{
    bool button1 = false;
    bool button2 = false;
    bool button3 = false;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Button1")
        {
            Debug.Log("Button 1 Pressed");
            button1 = true;
        }
        if (hit.gameObject.tag == "Button2")
        {
            button2 = true;
        }
        if (hit.gameObject.tag == "Button3")
        {
            button3 = true;
        }
    }

    public bool getButton1()
    {
        return button1;
    }

    public bool getButton2()
    {
        return button2;
    }

    public bool getButton3()
    {
        return button3;
    }

    public bool setButton1(bool trueOrFalse)
    {
        return button1 = trueOrFalse;
    }
}
