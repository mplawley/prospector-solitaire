using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

//The Scoreboard class manages showing the score to the player
public class Scoreboard : MonoBehaviour
{
	public static Scoreboard S; //The singleton for Scoreboard

	public GameObject prefabFloatingScore;

	[SerializeField]
	private int _score = 0;
	public string _scoreString;
	public Transform canvas;

	//The score property also sets the scoreString
	public int score
	{
		get
		{
			return(_score);
		}
		set
		{
			_score = value;
			scoreString = Utils.AddCommasToNumber(_score);
		}
	}

	//The scoreString propery also sets the Text.text
	public string scoreString
	{
		get
		{
			return (_scoreString);
		}
		set
		{
			_scoreString = value;
			GetComponent<Text>().text = _scoreString;
		}
	}

	void Awake()
	{
		S = this;
	}

	//When called by SendMessage, this adds the fs.score to this.score
	public void FSCallback(FloatingScore fs)
	{
		score += fs.score;
	}

	//This will Instantiate a new FloatingScore GameObject and initialize it.
	//It also returns a pointer to the FloatingSCore created so that the
	//calling function can do more with it (like set fontSizes, etc.)
	public FloatingScore CreateFloatingScore(int amt, List<Vector3> pts)
	{
		GameObject go = Instantiate(prefabFloatingScore) as GameObject;
		go.transform.SetParent(canvas);
		FloatingScore fs = go.GetComponent<FloatingScore>();
		fs.score = amt;
		fs.reportFinishTo = this.gameObject; //Set fs to call back to this
		fs.Init(pts);
		return(fs);
	}
}
