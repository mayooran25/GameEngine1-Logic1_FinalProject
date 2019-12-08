using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 6f;
    public Vector3 movement = Vector3.zero;

    public CharacterController characterController;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        //collect horizontal and vertical movement
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        //using the input, translate the player 
        Vector3 moveForward = transform.right * horz;
        Vector3 moveSide = transform.forward * vert;

        //tell the character controller the player is moving
        characterController.Move((moveForward + moveSide).normalized * movementSpeed * Time.deltaTime);
        //create a float out of the movement the character controller undergoes
        float speed = characterController.velocity.magnitude;
        //check to see if the player is moving and 
        animator.SetFloat("movementSpeed", speed);
    }
}
