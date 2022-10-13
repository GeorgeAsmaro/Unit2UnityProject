using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAndOff : MonoBehaviour
{
    public MeshRenderer platform;
    public BoxCollider collider;

    public float changeStateTimer;
    public float beginDelay;
    float maxTimerVal;

    bool isOn;
    bool begin = false;

    // Start is called before the first frame update
    void Start()
    {
        maxTimerVal = changeStateTimer;
        isOn = true;

        Invoke("BeginBehaviour", beginDelay);
    }

    // Update is called once per frame
    void Update()
    {
        if(begin)
        {
            changeStateTimer--;
            if (changeStateTimer <= 0)
            {
                ChangeState();

                changeStateTimer = maxTimerVal;
            }
        }
    }

    void ChangeState()
    {
        if(isOn)
        {
            platform.enabled = false;
            collider.enabled = false;
            isOn = false;
        }
        else
        {
            platform.enabled = true;
            collider.enabled = true;
            isOn = true;
        }
    }

    void BeginBehaviour()
    {
        begin = true;
    }
}
