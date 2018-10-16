﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta.HandInput;

public class resetPosition : MonoBehaviour {
    private Vector3 startingPos;
    private Vector3 currentPos;
    private float _gravity = -9.81f;
    public GameObject gameObject;

    // Use this for initialization
    void Start() {
        startingPos = gameObject.transform.position;
        Physics.gravity = new Vector3(0, _gravity, 0);
    }
        		
	
	
	// Update is called once per frame
	void Update () {
        currentPos = gameObject.transform.position;

        if (currentPos.y < -1)
        {
            gameObject.transform.position = startingPos; 
        }
	}
}
