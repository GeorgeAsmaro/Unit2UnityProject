using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLevelScript : MonoBehaviour
{
    public GameObject rockClimb;
    public GameObject floating2;
    public GameObject movingPlatform;
    private Animation anim;
    public GameObject player1;
    public GameObject player2;
    bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject rockClimb = GameObject.Find("RockClimbing");


        GameObject floating2 = GameObject.Find("FloatingPart2");

        if (!active)
        {
            rockClimb.SetActive(false);
            floating2.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        GameObject rockClimb = GameObject.Find("RockClimbing");
        

        GameObject floating2 = GameObject.Find("FloatingPart2");
        
        

        if (active)
        {
            rockClimb.SetActive(true);
            floating2.SetActive(true);
        }

        GameObject movingPlatform = GameObject.Find("MovingPlatform");
        anim = movingPlatform.GetComponent<Animation>();

        GameObject player1 = GameObject.Find("Player");
        GameObject player2 = GameObject.Find("Player2");
        bool button1Pressed = player1.GetComponent<ButtonPressed>().getButton1();
        bool button2Pressed = player1.GetComponent<ButtonPressed>().getButton2();
        bool button3Pressed = player1.GetComponent<ButtonPressed>().getButton3();

        bool button1Pressed2 = player2.GetComponent<ButtonPressed>().getButton1();
        bool button2Pressed2 = player2.GetComponent<ButtonPressed>().getButton2();
        bool button3Pressed2 = player2.GetComponent<ButtonPressed>().getButton3();

        if (button1Pressed || button1Pressed2)
        {
            anim.Play("UpAndDown");
            button1Pressed = player1.GetComponent<ButtonPressed>().setButton1(false);
            button1Pressed2 = player2.GetComponent<ButtonPressed>().setButton1(false);

        }

        if (button2Pressed || button2Pressed2)
        {
            active = true;
         
        }



    }
}
