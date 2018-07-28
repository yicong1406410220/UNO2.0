using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heap : MonoBehaviour {

    public List<Card> Heaps = new List<Card>();

    public GameObject objCard;

	// Use this for initialization
	void Start () {
        InitHeap();
        Shuffle();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// 初始化牌堆
    /// </summary>
    void InitHeap()
    {
        #region
        NewCard(CardNumbeType.N0, CardColorType.b);
        NewCard(CardNumbeType.N1, CardColorType.b);
        NewCard(CardNumbeType.N1, CardColorType.b);
        NewCard(CardNumbeType.N2, CardColorType.b);
        NewCard(CardNumbeType.N2, CardColorType.b);
        NewCard(CardNumbeType.N3, CardColorType.b);
        NewCard(CardNumbeType.N3, CardColorType.b);
        NewCard(CardNumbeType.N4, CardColorType.b);
        NewCard(CardNumbeType.N4, CardColorType.b);
        NewCard(CardNumbeType.N5, CardColorType.b);
        NewCard(CardNumbeType.N5, CardColorType.b);
        NewCard(CardNumbeType.N6, CardColorType.b);
        NewCard(CardNumbeType.N6, CardColorType.b);
        NewCard(CardNumbeType.N7, CardColorType.b);
        NewCard(CardNumbeType.N7, CardColorType.b);
        NewCard(CardNumbeType.N8, CardColorType.b);
        NewCard(CardNumbeType.N8, CardColorType.b);
        NewCard(CardNumbeType.N9, CardColorType.b);
        NewCard(CardNumbeType.N9, CardColorType.b);
        NewCard(CardNumbeType.Ndraw2, CardColorType.b);
        NewCard(CardNumbeType.Ndraw2, CardColorType.b);
        NewCard(CardNumbeType.Nreverse, CardColorType.b);
        NewCard(CardNumbeType.Nreverse, CardColorType.b);
        NewCard(CardNumbeType.Nskip, CardColorType.b);
        NewCard(CardNumbeType.Nskip, CardColorType.b);
        NewCard(CardNumbeType.N0, CardColorType.g);
        NewCard(CardNumbeType.N1, CardColorType.g);
        NewCard(CardNumbeType.N1, CardColorType.g);
        NewCard(CardNumbeType.N2, CardColorType.g);
        NewCard(CardNumbeType.N2, CardColorType.g);
        NewCard(CardNumbeType.N3, CardColorType.g);
        NewCard(CardNumbeType.N3, CardColorType.g);
        NewCard(CardNumbeType.N4, CardColorType.g);
        NewCard(CardNumbeType.N4, CardColorType.g);
        NewCard(CardNumbeType.N5, CardColorType.g);
        NewCard(CardNumbeType.N5, CardColorType.g);
        NewCard(CardNumbeType.N6, CardColorType.g);
        NewCard(CardNumbeType.N6, CardColorType.g);
        NewCard(CardNumbeType.N7, CardColorType.g);
        NewCard(CardNumbeType.N7, CardColorType.g);
        NewCard(CardNumbeType.N8, CardColorType.g);
        NewCard(CardNumbeType.N8, CardColorType.g);
        NewCard(CardNumbeType.N9, CardColorType.g);
        NewCard(CardNumbeType.N9, CardColorType.g);
        NewCard(CardNumbeType.Ndraw2, CardColorType.g);
        NewCard(CardNumbeType.Ndraw2, CardColorType.g);
        NewCard(CardNumbeType.Nreverse, CardColorType.g);
        NewCard(CardNumbeType.Nreverse, CardColorType.g);
        NewCard(CardNumbeType.Nskip, CardColorType.g);
        NewCard(CardNumbeType.Nskip, CardColorType.g);
        NewCard(CardNumbeType.N0, CardColorType.r);
        NewCard(CardNumbeType.N1, CardColorType.r);
        NewCard(CardNumbeType.N1, CardColorType.r);
        NewCard(CardNumbeType.N2, CardColorType.r);
        NewCard(CardNumbeType.N2, CardColorType.r);
        NewCard(CardNumbeType.N3, CardColorType.r);
        NewCard(CardNumbeType.N3, CardColorType.r);
        NewCard(CardNumbeType.N4, CardColorType.r);
        NewCard(CardNumbeType.N4, CardColorType.r);
        NewCard(CardNumbeType.N5, CardColorType.r);
        NewCard(CardNumbeType.N5, CardColorType.r);
        NewCard(CardNumbeType.N6, CardColorType.r);
        NewCard(CardNumbeType.N6, CardColorType.r);
        NewCard(CardNumbeType.N7, CardColorType.r);
        NewCard(CardNumbeType.N7, CardColorType.r);
        NewCard(CardNumbeType.N8, CardColorType.r);
        NewCard(CardNumbeType.N8, CardColorType.r);
        NewCard(CardNumbeType.N9, CardColorType.r);
        NewCard(CardNumbeType.N9, CardColorType.r);
        NewCard(CardNumbeType.Ndraw2, CardColorType.r);
        NewCard(CardNumbeType.Ndraw2, CardColorType.r);
        NewCard(CardNumbeType.Nreverse, CardColorType.r);
        NewCard(CardNumbeType.Nreverse, CardColorType.r);
        NewCard(CardNumbeType.Nskip, CardColorType.r);
        NewCard(CardNumbeType.Nskip, CardColorType.r);
        NewCard(CardNumbeType.N0, CardColorType.y);
        NewCard(CardNumbeType.N1, CardColorType.y);
        NewCard(CardNumbeType.N1, CardColorType.y);
        NewCard(CardNumbeType.N2, CardColorType.y);
        NewCard(CardNumbeType.N2, CardColorType.y);
        NewCard(CardNumbeType.N3, CardColorType.y);
        NewCard(CardNumbeType.N3, CardColorType.y);
        NewCard(CardNumbeType.N4, CardColorType.y);
        NewCard(CardNumbeType.N4, CardColorType.y);
        NewCard(CardNumbeType.N5, CardColorType.y);
        NewCard(CardNumbeType.N5, CardColorType.y);
        NewCard(CardNumbeType.N6, CardColorType.y);
        NewCard(CardNumbeType.N6, CardColorType.y);
        NewCard(CardNumbeType.N7, CardColorType.y);
        NewCard(CardNumbeType.N7, CardColorType.y);
        NewCard(CardNumbeType.N8, CardColorType.y);
        NewCard(CardNumbeType.N8, CardColorType.y);
        NewCard(CardNumbeType.N9, CardColorType.y);
        NewCard(CardNumbeType.N9, CardColorType.y);
        NewCard(CardNumbeType.Ndraw2, CardColorType.y);
        NewCard(CardNumbeType.Ndraw2, CardColorType.y);
        NewCard(CardNumbeType.Nreverse, CardColorType.y);
        NewCard(CardNumbeType.Nreverse, CardColorType.y);
        NewCard(CardNumbeType.Nskip, CardColorType.y);
        NewCard(CardNumbeType.Nskip, CardColorType.y);
        NewCard(CardNumbeType.Nwild, CardColorType.black);
        NewCard(CardNumbeType.Nwild, CardColorType.black);
        NewCard(CardNumbeType.Nwild, CardColorType.black);
        NewCard(CardNumbeType.Nwild, CardColorType.black);
        NewCard(CardNumbeType.Nwild4, CardColorType.black);
        NewCard(CardNumbeType.Nwild4, CardColorType.black);
        NewCard(CardNumbeType.Nwild4, CardColorType.black);
        NewCard(CardNumbeType.Nwild4, CardColorType.black);
        #endregion

    }

    void Shuffle()
    {
        for(int i=0; i< Heaps.Count-1; i++)
        {
            Card P = Heaps[i];
            int r = Random.Range(i+1, Heaps.Count);
            Heaps[i] = Heaps[r];
            Heaps[r] = P;
        }
    }

    void NewCard(CardNumbeType CNT, CardColorType CCT)
    {
        GameObject GCard = Instantiate(objCard, this.transform);
        Card card = GCard.GetComponent<Card>();
        Heaps.Add(card);
        card.SetCardSprite(CNT, CCT);
    }



}
