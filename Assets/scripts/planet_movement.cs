using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet_movement : MonoBehaviour
{
    // public vars
    public GameObject SUN;
    public int speed = 5;

    // System vars
    Vector3 moveAmount;
    Vector3 smoothMoveVelocity;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Look rotation:
        transform.LookAt(SUN.GetComponent<Renderer>().bounds.center);


        Vector3 moveDir = new Vector3(1, 0, 0) * speed;
        moveAmount = Vector3.SmoothDamp(moveAmount, moveDir, ref smoothMoveVelocity, .2f);
        Vector3 localMove = transform.TransformDirection(moveAmount) * Time.deltaTime;

        transform.position += localMove;

    }
}
