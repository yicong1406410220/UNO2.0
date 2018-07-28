using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {
  
    public CardColorType cardColorType = CardColorType.black;
    public CardNumbeType cardNumbeType = CardNumbeType.Nwild4;


    // Use this for initialization
    void Start () {
        SetCardSprite(cardNumbeType, cardColorType);
    }
	
	// Update is called once per frame
	void Update () {
       
	}

    public void SetCardSprite(CardNumbeType cardNumbeType, CardColorType cardColorType )
    {
        if(cardColorType != CardColorType.NNull)
        this.cardColorType = cardColorType;
        if(cardNumbeType != CardNumbeType.NNull)
        this.cardNumbeType = cardNumbeType;
        string name = cardColorType.ToString() + (cardNumbeType.ToString()).Substring(1, cardNumbeType.ToString().Length - 1);
        Debug.Log(name);
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Textures/" + name);
    }

}
