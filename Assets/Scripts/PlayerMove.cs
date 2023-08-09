using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // These will appear as listed
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private float crouchSpeed;
    [SerializeField] private Vector3 dir; //Vector3 is a struct - stores data. In this case it is dir.x, dir.y, dir.z

    [SerializeField] private Transform myTrans;

    // Start is called before the first frame update
    void Start()
    {
        myTrans = GetComponent<Transform>(); // name of object has to go in <>. getting the object as a transform... (a generic)
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    /*
    Movement Type

    Local - Like what is relative to the obj aka forward left right back
    Global - Like Compass Directions tot eh world aka North South East West
    */
    private void Move()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) // One of the easy ways to get a key rather than keycode.w; prefer not to use "w"
        {
            // myTrans.position += myTrans.forward; // Vectors can be added together (theyre cool like that B) ) << code works btw
            // myTrans.position += Vector3.forward; // Same as writing 0,0,1 << Adds every frame
        }

        float horizontal = 0; // runs through once however as this is checked per frame it is done once per frame (?)
        float vertical = 0;

        /* Checking wether player is going up down left right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // Right
            horizontal = 1;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // Left
            horizontal = -1;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) // Up
            vertical = 1;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) // Down
            vertical = -1;

        8 lines to 2 lines B) */

        // Same as above however using inbuilt / baked unity func and in 2 lines B)
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        dir.x = horizontal;
        dir.y = 0;
        dir.z = vertical;

        float speed = walkSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
            speed = runSpeed;

        if (Input.GetKey(KeyCode.LeftControl))
            speed = crouchSpeed;

        transform.position += dir * speed * Time.deltaTime; // Can times by an int / float hint; speed limiter :))))
        // delta time is how much time has passed in realworld between frames even out

        
    }
}
