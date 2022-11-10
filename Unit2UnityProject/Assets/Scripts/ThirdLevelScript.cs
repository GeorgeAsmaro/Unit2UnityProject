using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLevelScript : MonoBehaviour
{

    public GameObject movingPlatform;

    private Animation anim;
    private Animation buttonpress;
    private Animation rockWallAnim;
    private Animation rock1Anim;
    private Animation rock2Anim;
    private Animation rock3Anim;
    private Animation rock4Anim;
    private Animation rock5Anim;
    private Animation floating2Anim;
    private Animation buttonpress2;
    private Animation buttonpress3;
    private Animation podPart1;
    private Animation podPart2;
    private Animation podPart22;
    private Animation podPart3;
    private Animation podPart32;
    private Animation cameraChange;
    private Animation spawnChange;
    private Animation spawnChange2;
    private Animation podsToSecond;


    public GameObject player1;
    public GameObject player2;
    public GameObject button1;
    public GameObject rock1Obj;
    public GameObject rock2Obj;
    public GameObject rock3Obj;
    public GameObject rock4Obj;
    public GameObject rock5Obj;
    public GameObject floatingPart2;
    public GameObject button2;
    public GameObject pods;
    public GameObject PodDoor1;
    public GameObject PodDoor2;
    public GameObject player2WP;
    public GameObject player1WP;
    public GameObject camera;
    public GameObject spawn1;
    public GameObject spawn2;
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
    bool animatonPlayedWall = false;

    bool animatonPlayedBlocks = false;

    bool Button2Unpressed = true;
    bool Button3Unpressed = true;
    bool doorAnimPlayed = false;
    bool part1Touched = false;
    bool part2Touched = false;
    bool part1Touched2 = false;
    bool part2Touched2 = false;
    bool doorCloseAnimPlayed = false;
    bool spawnChanged = false;
    bool podsMoved = false;
    
    int timer = 100;
    int doorOpenTime = 250;
    int doorCloseTime = 250;
    int podsMoveTime = 50;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(podsMoveTime);

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

        GameObject rock1Obj = GameObject.Find("Rock1");
        rock1Anim = rock1Obj.GetComponent<Animation>();

        GameObject rock2Obj = GameObject.Find("Rock5");
        rock2Anim = rock2Obj.GetComponent<Animation>();

        GameObject rock3Obj = GameObject.Find("Rock2");
        rock3Anim = rock3Obj.GetComponent<Animation>();

        GameObject rock4Obj = GameObject.Find("Rock3");
        rock4Anim = rock4Obj.GetComponent<Animation>();

        GameObject rock5Obj = GameObject.Find("Rock4");
        rock5Anim = rock5Obj.GetComponent<Animation>();

        GameObject floating2 = GameObject.Find("FloatingPart2");
        floating2Anim = floating2.GetComponent<Animation>();

        GameObject pods = GameObject.Find("Pods");
        podPart1 = pods.GetComponent<Animation>();

        GameObject PodDoor1 = GameObject.Find("PodDoor1");
        podPart2 = PodDoor1.GetComponent<Animation>();

        GameObject PodDoor2 = GameObject.Find("PodDoor2");
        podPart22 = PodDoor2.GetComponent<Animation>();

        GameObject camera = GameObject.Find("Main Camera");
        cameraChange = camera.GetComponent<Animation>();

        



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
            timer--;
            
            if(!animatonPlayedWall)
            {

                rockWallCol.enabled = true;
                rockWallRend.enabled = true;

                rockWallAnim.Play("RockClimbWall");

                


                animatonPlayedWall = true;
            }

            
            if(timer <= 0 && !animatonPlayedBlocks)
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


                rock1Anim.Play("rock1Anim");

                rock2Anim.Play("rock2Anim");

                rock3Anim.Play("rock3Anim");

                rock4Anim.Play("rock4Anim");

                rock5Anim.Play("rock5Anim");

                floating2Anim.Play("Floating2Anim");

                animatonPlayedBlocks = true;
            }
            
        }

        GameObject movingPlatform = GameObject.Find("MovingPlatform");
        anim = movingPlatform.GetComponent<Animation>();

        GameObject button1 = GameObject.Find("ButtonPress");
        buttonpress = button1.GetComponent<Animation>();

        GameObject testPlat = GameObject.Find("TestPlatform");

        rockWallAnim = rockWall.GetComponent<Animation>();

        

        GameObject player1 = GameObject.Find("Player");
        GameObject player2 = GameObject.Find("Player2");

        part1Touched = player1.GetComponent<BothPlayersTouching>().getTouching();
        part1Touched2 = player2.GetComponent<BothPlayersTouching>().getTouching();

        part2Touched = player1.GetComponent<BothPlayersTouching>().getTouching2();
        part2Touched2 = player2.GetComponent<BothPlayersTouching>().getTouching2();

        bool button1Pressed = player1.GetComponent<ButtonPressed>().getButton1();
        bool button2Pressed = player1.GetComponent<ButtonPressed>().getButton2();
        bool button3Pressed = player1.GetComponent<ButtonPressed>().getButton3();

        bool button1Pressed2 = player2.GetComponent<ButtonPressed>().getButton1();
        bool button2Pressed2 = player2.GetComponent<ButtonPressed>().getButton2();
        bool button3Pressed2 = player2.GetComponent<ButtonPressed>().getButton3();

        if (button1Pressed || button1Pressed2)
        {
            buttonpress.Play("buttonPress");
            anim.Play("UpAndDown");
            
            
            button1Pressed = player1.GetComponent<ButtonPressed>().setButton1(false);
            button1Pressed2 = player2.GetComponent<ButtonPressed>().setButton1(false);

        }

        if (button2Pressed || button2Pressed2)
        {
            active = true;
            
            if(Button2Unpressed)
            {
                GameObject button2 = GameObject.Find("ButtonPress2");
                buttonpress2 = button2.GetComponent<Animation>();

                buttonpress2.Play("button2Press");
                Button2Unpressed = false;
            }

        }

        if (button3Pressed || button3Pressed2)
        {
            doorOpenTime--;
            if(Button3Unpressed)
            {
                GameObject button3 = GameObject.Find("ButtonPress3");
                buttonpress3 = button3.GetComponent<Animation>();

                buttonpress3.Play("button3Press");
                Button3Unpressed = false;

                podPart1.Play("PodsAnimation");
            }

            if(doorOpenTime <= 0 && !doorAnimPlayed)
            {
                podPart2.Play("PodsDoorAnim2");
                podPart22.Play("PodsDoorAnim2");
                doorAnimPlayed = true;

                
            }
            




        }

        if((part1Touched && part2Touched2))
        {
            doorCloseTime--;
            podPart3 = PodDoor1.GetComponent<Animation>();
            podPart32 = PodDoor2.GetComponent<Animation>();

            if(doorCloseTime <= 0 && !doorCloseAnimPlayed )
            {
                podPart3.Play("PodsDoorAnim1");
                podPart32.Play("PodsDoorAnim1");
                doorCloseAnimPlayed = true;

                cameraChange.Play("CameraChange");

                if(!spawnChanged)
                {
                    GameObject spawn = GameObject.Find("Player1Spawn");
                    spawnChange = spawn.GetComponent<Animation>();
                    spawnChange.Play("spawnChange");

                    GameObject spawn2 = GameObject.Find("Player2Spawn");
                    spawnChange2 = spawn2.GetComponent<Animation>();
                    spawnChange2.Play("spawnChange2");

                    spawnChanged = true;
                }

                podsToSecond = pods.GetComponent<Animation>();

                if(spawnChanged)
                {
                    if(podsMoveTime > 0)
                    {
                        podsMoveTime--;
                    }
                    
                }

                if(!podsMoved && spawnChanged)
                {
                    

                    if(podsMoveTime <=0)
                    {
                        podsToSecond.Play("PodsAnimation2");
                        podsMoved = true;
                    }
                    
                }   
                

            }
            

            float p1WP = player1.GetComponent<PlayerFallWarp>().setTPLevel(-20);
            float p2WP = player2.GetComponent<PlayerFallWarp>().setTPLevel(-20);
        }


    }

    public bool getPart1()
    {
        return part1Touched;
    }

    public bool setPart1(bool touched)
    {
        return part1Touched = touched;
    }

    public bool getPart2()
    {
        return part2Touched;
    }

    public bool setPart2(bool touched)
    {
        return part2Touched = touched;
    }
}
