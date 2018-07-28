using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heap : MonoBehaviour {

    public List<Card> Heaps = new List<Card>();

    public GameObject objCard;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 初始化牌堆
    /// </summary>
    void InitHeap()
    {
        if ()
        

    }

    void NewCard(CardColorType CCT, CardNumbeType CNT)
    {
        GameObject GCard = Instantiate(objCard, this.transform);
        Card card = GCard.GetComponent<Card>();
        Heaps.Add(card);
        card.SetCardSprite(CCT, CNT);
    }



}
