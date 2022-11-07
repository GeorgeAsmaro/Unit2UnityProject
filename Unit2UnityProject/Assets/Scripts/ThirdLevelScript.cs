using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLevelScript : MonoBehaviour
{

    public GameObject movingPlatform;
    private Animation anim;
    public GameObject player1;
    public GameObject player2;
    bool active = false;

    public BoxCollider rock1Col;
    public BoxCollider rock2Col;
    public BoxCollider rock3Col;
    public BoxCollider rock4Col;
    public BoxCollider rock5Col;
    public BoxCollider rockWallCol;
   
    public MeshRenderer rock1Rend;
    public MeshRenderer rock2Rend;
    public MeshRenderer rock3Rend;
    public MeshRenderer rock4Rend;
    public MeshRenderer rock5Rend;
    public MeshRenderer rockWallRend;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        GameObject rock1 = GameObject.Find("Rock1");
        rock1Col = rock1.GetComponent<BoxCollider>();
        rock1Rend = rock1.GetComponent<MeshRenderer>();

        GameObject rock2 = GameObject.Find("Rock2");
        rock2Col = rock2.GetComponent<BoxCollider>();
        rock2Rend = rock2.GetComponent<MeshRenderer>();

        GameObject rock3 = GameObject.Find("Rock3");
        rock3Col = rock3.GetComponent<BoxCollider>();
        rock3Rend = rock3.GetComponent<MeshRenderer>();

        GameObject rock4 = GameObject.Find("Rock4");
        rock4Col = rock4.GetComponent<BoxCollider>();
        rock4Rend = rock4.GetComponent<MeshRenderer>();

        GameObject rock5 = GameObject.Find("Rock5");
        rock5Col = rock5.GetComponent<BoxCollider>();
        rock5Rend = rock5.GetComponent<MeshRenderer>();

        GameObject rockWall = GameObject.Find("RockWall");
        rockWallCol = rockWall.GetComponent<BoxCollider>();
        rockWallRend = rockWall.GetComponent<MeshRenderer>();

        if (!active)
        {
            rock1Col.enabled = false;
            rock1Rend.enabled = false;

            rock2Col.enabled = false;
            rock2Rend.enabled = false;

            rock3Col.enabled = false;
            rock3Rend.enabled = false;

            rock4Col.enabled = false;
            rock4Rend.enabled = false;

            rock5Col.enabled = false;
            rock5Rend.enabled = false;

            rockWallCol.enabled = false;
            rockWallRend.enabled = false;
        }

        if (active)
        {
            rock1Col.enabled = true;
            rock1Rend.enabled = true;

            rock2Col.enabled = true;
            rock2Rend.enabled = true;

            rock3Col.enabled = true;
            rock3Rend.enabled = true;

            rock4Col.enabled = true;
            rock4Rend.enabled = true;

            rock5Col.enabled = true;
            rock5Rend.enabled = true;

            rockWallCol.enabled = true;
            rockWallRend.enabled = true;
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
