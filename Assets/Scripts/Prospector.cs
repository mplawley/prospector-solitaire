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
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}
}
