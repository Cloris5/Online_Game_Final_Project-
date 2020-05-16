﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LFZ_Cloud : MonoBehaviour
{
    [SerializeField]//we gonna expose this variable in the editor 
    private float speed;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0, 0, speed);
        Invoke("FallDestroy", 10f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FallDestroy()
    {
        rb.useGravity = true;
        Destroy(transform.gameObject, 0.5f);
    }
}