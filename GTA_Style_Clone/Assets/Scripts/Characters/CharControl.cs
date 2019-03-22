using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{

    //public variable (might be refactored depending on how they are used in later tutorial videos)
    public GameObject thePlayer;


    //private but viewable in Inspector window
    [SerializeField] private float _horizontalSpeed = 150;
    [SerializeField] private float _verticalSpeed = 8;


    //hidden from Inspector window
    private Animation _anim;
    private bool _isRunning;
    private float _horizontalMove;
    private float _verticalMove;


    private void Start()
    {
        _anim = thePlayer.GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            _anim.Play("Run");
            _horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * _horizontalSpeed;    //spinning around on y
            _verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * _verticalSpeed;          //forwards and backwards on zed
            _isRunning = true;
            transform.Rotate(0, _horizontalMove, 0);
            transform.Translate(0, 0, _verticalMove);
        }
        else
        {
            _anim.Play("Idle");
            _isRunning = false;
        }
    }
}
