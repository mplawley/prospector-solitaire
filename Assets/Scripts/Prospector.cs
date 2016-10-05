using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Prospector : MonoBehaviour
{
	static public Prospector S;
	public Deck deck;
	public TextAsset deckXML;

	void Awake()
	{
		S = this; //Prospector singleton
	}

	// Use this for initialization
	void Start()
	{
		deck = GetComponent<Deck>(); //Get the Deck
		deck.InitDeck(deckXML.text); //Pass DeckXML to it
		Deck.Shuffle(ref deck.cards); //This shuffles the deck. The ref keyword passes a reference to deck.cards, which allows
		//deck.cards to be modified by Deck.Shuffle()
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
}
