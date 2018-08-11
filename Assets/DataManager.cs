using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {

    public static DataManager instance;

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
