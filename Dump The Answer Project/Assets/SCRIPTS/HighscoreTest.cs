using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighscoreTest : MonoBehaviour {

	static Text scoreText;
	static Text messageText;
	static int currentScore = 0;
	static string currentMessage = "Let's Play";
	public int ScoreToWin;
	static Text HighScoreText;
	static int highscore;

	public Animator GameOverAnim;

	// Use this for initialization
	void Start ()
	{
		currentScore = 0;
		scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
		messageText  = GameObject.FindGameObjectWithTag("MessageText").GetComponent<Text>();
		HighScoreText = GameObject.FindGameObjectWithTag ("highscoretext").GetComponent<Text>();
		UpdateScore(currentScore);
		UpdateMessage(currentMessage);
		UpdateHighScore();
	}

	public static void UpdateScore(int addedValue)
	{
		currentScore += addedValue;
		scoreText.text = "" + currentScore;

	}

	public static void UpdateMessage(string message)
	{
		currentMessage = message;
		messageText.text = currentMessage;
	}


	public static void UpdateHighScore()
	{
		
		if (currentScore > highscore) 
		{
			highscore = currentScore;
		}

		HighScoreText.text = "HighScore: " + highscore;

	}

	// Update is called once per frame
	void Update () 
	{
		if (currentScore == ScoreToWin )
			GameOverAnim.SetTrigger ("Gameover");
	}


}

