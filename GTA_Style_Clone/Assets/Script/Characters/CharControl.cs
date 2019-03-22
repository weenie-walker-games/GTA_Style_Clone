using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{

    public GameObject thePlayer;
    public bool isRunning;
    public float horizontalMove;
    public float verticalMove;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            thePlayer.GetComponent<Animation>().Play("Run");
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;    //spinning around on y
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 8;          //forwards and backwards on zed
            isRunning = true;
            transform.Rotate(0, horizontalMove, 0);
            transform.Translate(0, 0, verticalMove);
        }
    }
}
