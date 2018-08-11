using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour {

    public int FaceID;

    public PersonType personType;

    public enum PersonType
    {
        AI,
        player,
    }

    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
