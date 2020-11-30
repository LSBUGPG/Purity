﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private float speed;
    public float walkSpeed = 0.02f;
    public float runSpeed = 0.06f;
    public float rotationSpeed = 2.5f;

    Rigidbody rigidbody;
    Animator animator;
    CapsuleCollider capsuleCollider;

    public Transform tCameraTransform;

    private float yaw = 0;
    private float pitch = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
        capsuleCollider = gameObject.GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Vertical") * speed;
        float y = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.Translate(0, 0, z);
        transform.Rotate(0, y, 0);

        yaw += rotationSpeed * y;//Input.GetAxis("Mouse X");
        pitch -= rotationSpeed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(0, yaw, 0);
        tCameraTransform.eulerAngles = new Vector3(pitch, 0);

        if (Input.GetKey(KeyCode.LeftShift))


            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsRunning", true);
                animator.SetBool("IsIdle", false);

            }
            else
            {
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsRunning", false);
                animator.SetBool("IsIdle", true);

                speed = runSpeed;
            }
             



           else
        {
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("IsWalking", true);
                animator.SetBool("IsRunning", false);
                animator.SetBool("IsIdle", false);

            }
            else
            {
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsRunning", false);
                animator.SetBool("IsIdle", true);
            }
            speed = walkSpeed;
        }
    }
}



