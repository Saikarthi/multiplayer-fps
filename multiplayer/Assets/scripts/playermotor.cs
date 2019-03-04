﻿using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class playermotor : MonoBehaviour
{
    private Vector3 vel = Vector3.zero;
    public Camera cam;
    private Vector3 rot = Vector3.zero;
    private Vector3 cam1 = Vector3.zero;
    private Rigidbody rb;
    private Vector3 ap = Vector3.zero;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void move(Vector3 _velo)
    {
        vel = _velo;
    }

    public void ro(Vector3 _v)
    {
        rot = _v;
    }
    public void co(Vector3 _v)
    {
        cam1 = _v;
    }
    void FixedUpdate()
    {
        //output
        pe();
        re();
        Ce();
    }
    
    public void pe()
    {
        if (vel != Vector3.zero)
        {

            rb.MovePosition(rb.position + vel * Time.deltaTime);
        }
        if(ap != Vector3.zero)
        {

            rb.AddForce(ap * Time.deltaTime, ForceMode.Acceleration);
        }
    }
    public void re()
    {
        if (rot != Vector3.zero)
        {

            rb.MoveRotation(rb.rotation * Quaternion.Euler(rot));
        }
    }
    public void applythu(Vector3 _thu)
    {
        ap = _thu;
    }
    public void Ce()
    {
        if (cam != null)
        {

            cam.transform.Rotate(-cam1);
        }
    }
}