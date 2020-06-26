using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]
public class DragLaunch : MonoBehaviour
{
    private Ball ball;
    private Vector3 dragStart, dragEnd;
    private float startTime, endTime;

    void Start()
    {
        ball = GetComponent<Ball>();
    }


    void Update()
    {

    }

    public void DragStart()
    {
        dragStart = Input.mousePosition;
        startTime = Time.time;
    }

    public void DragEnd()
    {
        dragEnd = Input.mousePosition;
        startTime = Time.time;
        float dragDuration = endTime - startTime;
        float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
        float launchSpeexZ = (dragEnd.y - dragStart.y) / dragDuration;
        Vector3 launchVelocity = new Vector3(launchSpeedX, 0, launchSpeexZ);
        ball.Launch(launchVelocity);
    }

    public void MoveStart(float amount)
    {
        if (!ball.inPlay)
        {
            ball.transform.Translate(new Vector3(amount, 0, 0));
        }

    }
}
