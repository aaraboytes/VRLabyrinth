using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed,maxSpeed,jumpForce;

    //Rigidbody rb;
    CharacterController player;
    Vector3 move = Vector3.zero;
    [SerializeField]
    bool running = false;
    private void Start()
    {
       //rb = GetComponent<Rigidbody>();
        player = GetComponent<CharacterController>();
    }
    void Update () {
        if (player.isGrounded)
        {
            running = Input.GetKey(KeyCode.LeftShift);
            move = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
            if (Input.GetButton("Jump"))
            {
                move.y = jumpForce;
            }
        }
        else {
            move.y += Physics.gravity.y * Time.deltaTime;
        }
        player.Move(move*(running?maxSpeed:speed)*Time.deltaTime);
    }
}
