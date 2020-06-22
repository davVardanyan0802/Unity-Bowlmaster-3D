using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rigidbody;
    private AudioSource audioSource;
    public float laubchSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        Launch();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Launch()
    {
        rigidbody.velocity = new Vector3(0, 0, laubchSpeed);

        audioSource.Play();
    }
}
