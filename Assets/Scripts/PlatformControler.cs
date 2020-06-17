using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControler : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController ch_controller;
    public GameObject Player;
    private Vector3 moveVector;
    // public Random rand = new Random();
    public System.Random rand = new System.Random();

    int x=0;
    int z=0;
    void Start()
    {
    ch_controller = GetComponent<CharacterController>();
    // Player = FindObjectOfTag("Player");
    }

    // Update is called once per frame
    void Update()
  {
    moveVector = Vector3.zero;

    if(Player.transform.position.y - ch_controller.transform.position.y > 10)
    {
        // moveVector.y+=25;
        moveVector.x=1000;
        // moveVector.y+=50;
        // print(moveVector.y);
        ch_controller.Move(moveVector);
        moveVector = Vector3.zero;
        moveVector.y+=25;
        x=rand.Next(5,10);
        moveVector.x=x-Player.transform.position.x;
        z=rand.Next(27,33);
        ch_controller.Move(moveVector);
        moveVector = Vector3.zero;
        moveVector.x=-1000;
        ch_controller.Move(moveVector);

        
        // print(ch_controller.transform.position.y);
    }

    }
}
