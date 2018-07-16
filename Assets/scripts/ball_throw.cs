using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ball_throw : MonoBehaviour
{
    public Rigidbody ball;
    public Transform target;

    private Camera fbsCam;
    private LineRenderer laserLine;



    public float h = 10;
    public float gravity = -18;

    public bool debugPath;


    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        ball.useGravity = false;
        laserLine = GetComponent<LineRenderer>();
        fbsCam = GetComponentInParent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Camera.main.WorldToViewportPoint(Input.mousePosition);
            target.transform.position = new Vector3(mousePos.x, mousePos.y, 0f);

            laserLine.SetPosition(0, transform.position);
            laserLine.enabled = true;
            Launch();
            laserLine.enabled = false;


        }
    }
    void Launch()
    {
        Physics.gravity = Vector3.up * gravity;
        ball.useGravity = true;
        ball.velocity = CalculateLaunceVelocity();

    }

    Vector3 CalculateLaunceVelocity()
    {
        print(target);
        float displacementY = target.position.y - ball.position.y;
        Vector3 displacementXZ = new Vector3(target.position.x - ball.position.x, 0, target.position.z - ball.position.z);
        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2 * gravity * h);
        Vector3 velocityXZ = displacementXZ / (Mathf.Sqrt(2 * (displacementY - h) / gravity));
        return velocityXZ + velocityY;


    }



}
