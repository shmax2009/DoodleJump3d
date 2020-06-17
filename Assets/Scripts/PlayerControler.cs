using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
public class PlayerControler : MonoBehaviour
{
    public float speedMove;
    public float jumpPower;

    private float gravityForce;
    private Vector3 moveVector;
    protected Joystick joystick;
    public Transform pl_t;
    // public Button bhjutton;
    private CharacterController ch_controller;
    private float gravity=0;
    // private ButtonControler bcontrl;
    // Start is called before the first frame update
    // void OnBecameVisible()
    // {
    //     // enabled = true;
    //     print(true)
    // }
    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        joystick = FindObjectOfType<Joystick>();
        // joystick = GameObject.Find("Jump");

    }

    // Update is called once per frame
    public void Update()
    {
        CharacterMove();
        // GameGravity();
    }

    private void CharacterMove()
    {
        moveVector = Vector3.zero;
        moveVector.x = joystick.Horizontal* speedMove * -1;
        moveVector.z = joystick.Vertical * speedMove * -1;
        if(ch_controller.isGrounded){
            gravity=10.0f;
        }
        moveVector.y += gravity;
        ch_controller.Move(moveVector * Time.deltaTime);
        gravity-=0.1f;
    }
    public float getY()
    {
        return pl_t.position.y; 
    }
    // private void GameGravity()
    // {
    //     if (!ch_controller.isGrounded) gravityForce -= 20.0f * Time.deltaTime;
    //     else gravityForce = -1f;
    // }
}