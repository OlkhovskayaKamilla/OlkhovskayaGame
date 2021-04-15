using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speedMove;
    private float gravityForce;
    private Vector3 moveVector;
    public int score = 0;
    public int score2 = 0;
    public Text txt;
    public Text txt2;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            score++;
            score2 = score;
        }

    }


    private CharacterController ch_controller;

    

    private void Start()
    {
        ch_controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        CharacterMove();
        GamingGravity();
        txt.text = "Score: " + score;
        txt2.text = "Your score: " + score2;
    }

    private void CharacterMove()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * speedMove;
        moveVector.z = Input.GetAxis("Vertical") * speedMove;

        moveVector.y = gravityForce;
        ch_controller.Move(moveVector * Time.deltaTime); 
    }

    private void GamingGravity()
    {
        if (!ch_controller.isGrounded) { gravityForce -= 20f * Time.deltaTime;
        }else { gravityForce = -1f;}
    }

    
}