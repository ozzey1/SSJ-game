﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogMove : MonoBehaviour
{
    public float moveSpeed = 2;
    public Transform moveTarget;
    public LayerMask whatStopsMovement;
    public bool stopTurtle;

    void Start()
    {
        moveTarget.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        //move to moveTarget
        transform.position = Vector3.MoveTowards(transform.position, moveTarget.position, moveSpeed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, moveTarget.position) <= 0.5f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1)
            {
                
                do //frog goes one direction until it collides
                {
                    //detects collions
                     if (!Physics2D.OverlapCircle(moveTarget.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement))
                     {
                     
                            moveTarget.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                            //okami's rotate/flip sprite script
                            if (Mathf.Sign(Input.GetAxisRaw("Horizontal")) == 1) { transform.eulerAngles = new Vector3(0, 0, -90); }
                            else { transform.eulerAngles = new Vector3(0, 0, 90); }
                            //
                            
                     }
                } while (!Physics2D.OverlapCircle(moveTarget.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopsMovement));

                
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1)
            {
                do //frog goes one direction until it collides
                {
                    if (!Physics2D.OverlapCircle(moveTarget.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement))
                    {
                        stopTurtle = true;
                        moveTarget.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                        //okami's rotate/flip sprite script
                        if (Mathf.Sign(Input.GetAxisRaw("Vertical")) == 1) { transform.eulerAngles = new Vector3(0, 0, 0); }
                        else { transform.eulerAngles = new Vector3(0, 0, 180); }
                        //
                       
                    }
                } while (!Physics2D.OverlapCircle(moveTarget.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopsMovement));
                
            }
        }
    }
}
