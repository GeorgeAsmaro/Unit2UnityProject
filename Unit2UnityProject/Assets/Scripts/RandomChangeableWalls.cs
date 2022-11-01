using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChangeableWalls : MonoBehaviour
{
    int rand;

    public MeshCollider meshCollider;
    public MeshRenderer renderer;

    public MeshCollider meshCollider2;
    public MeshRenderer renderer2;

    public MeshCollider meshCollider3;
    public MeshRenderer renderer3;

    public MeshCollider meshCollider4;
    public MeshRenderer renderer4;

    public MeshCollider meshCollider5;
    public MeshRenderer renderer5;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 4);
        Debug.Log(rand);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject change1 = GameObject.Find("Changeable1");
        meshCollider =  change1.GetComponent<MeshCollider>();
        renderer = change1.GetComponent<MeshRenderer>();

        GameObject change2 = GameObject.Find("Changeable2");
        meshCollider2 = change2.GetComponent<MeshCollider>();
        renderer2 = change2.GetComponent<MeshRenderer>();

        GameObject change3 = GameObject.Find("Changeable3");
        meshCollider3 = change3.GetComponent<MeshCollider>();
        renderer3 = change3.GetComponent<MeshRenderer>();

        GameObject change4 = GameObject.Find("Changeable4");
        meshCollider4 = change4.GetComponent<MeshCollider>();
        renderer4 = change4.GetComponent<MeshRenderer>();

        GameObject change5 = GameObject.Find("Changeable5");
        meshCollider5 = change5.GetComponent<MeshCollider>();
        renderer5 = change5.GetComponent<MeshRenderer>();

        if(rand == 1)
        {
            Destroy(meshCollider);
            Destroy(renderer);
            Destroy(meshCollider5);
            Destroy(renderer5);
            Destroy(meshCollider2);
            Destroy(renderer2);
        }

        if (rand == 2)
        {
            Destroy(meshCollider);
            Destroy(renderer);
            Destroy(meshCollider5);
            Destroy(renderer5);
            Destroy(meshCollider3);
            Destroy(renderer3);
        }

        if (rand == 3)
        {
            Destroy(meshCollider);
            Destroy(renderer);
            Destroy(meshCollider4);
            Destroy(renderer4);
            Destroy(meshCollider3);
            Destroy(renderer3);
        }

        if (rand == 4)
        {
            Destroy(meshCollider2);
            Destroy(renderer2);
        }
    }
}
