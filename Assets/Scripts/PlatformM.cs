﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformM : MonoBehaviour
{
    
    public Transform target;
    public float speed;
    private Vector3 start, end;


    private void Start()
    {
        if (target != null) 
        {
            target.parent = null;
            start = transform.position;
            end = target.position;
        }
    }

    private void FixedUpdate()
    {
        if (target != null) 
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);
        }
        if(transform.position== target.position)
        {
            target.position = (target.position == start) ? end : start;
        }

        Debug.DrawLine(transform.position, target.position);

    }
    



}
