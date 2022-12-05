using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    bool part1Touched;
    bool part1Touched2;
    bool part2Touched;
    bool part2Touched2;
    bool podsLeft;
    bool lvl2Touched;
    public GameObject respawnPoint;
    public GameObject player1;
    public GameObject player2;
    public GameObject levelRunner;

    // Update is called once per frame
    void Update()
    {
        part1Touched = player1.GetComponent<BothPlayersTouching>().getTouching();
        part1Touched2 = player2.GetComponent<BothPlayersTouching>().getTouching();
        
        getPods();

        part2Touched = player1.GetComponent<BothPlayersTouching>().getTouching2();
        part2Touched2 = player2.GetComponent<BothPlayersTouching>().getTouching2();

        CharacterController controller = GetComponent<CharacterController>();

        if(podsLeft) {
            part1Touched = true;
            part1Touched2 = true;
            part2Touched = true;
            part2Touched2 = true;
        }
        Debug.Log(lvl2Touched);
        if(Input.GetButtonDown("Fire3") && !part1Touched && !part1Touched2 && !part2Touched && !part2Touched2) {
            if(controller != null) {
                controller.enabled = false;
                controller.transform.position = respawnPoint.transform.position;
                controller.enabled = true;
            }
        }
        else if(Input.GetButtonDown("Fire3") && lvl2Touched) {
            if(controller != null) {
                controller.enabled = false;
                controller.transform.position = respawnPoint.transform.position;
                controller.enabled = true;
            }
        }
    }

    public bool setPodsleft(bool left) {
        return podsLeft = left;
    }

    public bool getPods() {
        return podsLeft;
    }

    public bool getLvl2() {
        return lvl2Touched;
    }


    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if(hit.gameObject.tag == "lvl2") {
            lvl2Touched = true;
        }
    }
}
