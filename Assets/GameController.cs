﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance;

	// Use this for initialization
	void Start () {
        if (instance == null)
        {
            instance = this;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
