﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rigidbody;
    private AudioSource audioSource;
    public Vector3 launchVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
       
    }

    public void Launch(Vector3 velocity)
    {
        rigidbody.useGravity = true;
        audioSource = GetComponent<AudioSource>();
        rigidbody.velocity = launchVelocity;

        audioSource.Play();
    }


    void Update()
    {

    }


}
