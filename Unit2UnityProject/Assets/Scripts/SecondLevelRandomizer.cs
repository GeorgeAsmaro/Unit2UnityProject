using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevelRandomizer : MonoBehaviour
{

    int rand;

    int rand2;

    int rand3;

    public GameObject red1;

    public GameObject red2;

    public GameObject red3;

    public GameObject yellow1;

    public GameObject green1;

    public GameObject green2;

    public GameObject blue1;

    public GameObject blue2;

    public GameObject blue3;

    public MeshCollider red1collider;

    public MeshCollider red2collider;

    public MeshCollider red3collider;

    public MeshCollider yellow1collider;

    public MeshCollider green1collider;

    public MeshCollider green2collider;

    public MeshCollider blue1collider;

    public MeshCollider blue2collider;

    public MeshCollider blue3collider;

    // Start is called before the first frame update
    void Start()
    {

        red1collider = red1.GetComponent<MeshCollider>();
        red2collider = red2.GetComponent<MeshCollider>();
        red3collider = red3.GetComponent<MeshCollider>();

        yellow1collider = yellow1.GetComponent<MeshCollider>();

        green1collider = green1.GetComponent<MeshCollider>();
        green2collider = green2.GetComponent<MeshCollider>();

        blue1collider = blue1.GetComponent<MeshCollider>();
        blue2collider = blue2.GetComponent<MeshCollider>();
        blue3collider = blue3.GetComponent<MeshCollider>();

        rand = Random.Range(1, 4);

        rand2 = Random.Range(1, 3);

        rand3 = Random.Range(1, 2);

        if(rand == 1)
        {
            Destroy(yellow1collider);
            Destroy(green1collider);
            Destroy(blue1collider);
            Debug.Log("red");
        }
        else if(rand == 2)
        {
            Destroy(red1collider);
            Destroy(green1collider);
            Destroy(blue1collider);
            Debug.Log("yellow");
        }
        else if(rand == 3)
        {
            Destroy(red1collider);
            Destroy(yellow1collider);
            Destroy(blue1collider);
            Debug.Log("green");
        }
        else
        {
            Destroy(red1collider);
            Destroy(yellow1collider);
            Destroy(green1collider);
            Debug.Log("blue");
        }

        if(rand2 == 1)
        {
            Destroy(green2collider);
            Destroy(blue2collider);
            Debug.Log("red");
        }
        else if(rand2 == 2)
        {
            Destroy(red2collider);
            Destroy(blue2collider);
            Debug.Log("green");
        }
        else
        {
            Destroy(red2collider);
            Destroy(green2collider);
            Debug.Log("blue");
        }

        if(rand3 == 1)
        {
            Destroy(blue3collider);
            Debug.Log("red");
        }
        else
        {
            Destroy(red3collider);
            Debug.Log("blue");
        }
    }

}
