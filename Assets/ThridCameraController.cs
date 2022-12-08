﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThridCameraController : MonoBehaviour
{
    public GameObject character;
    Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - character.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = character.transform.position + offset;
    }
}
