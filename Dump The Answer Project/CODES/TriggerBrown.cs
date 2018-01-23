using UnityEngine;
using System.Collections;

public class TriggerBrown : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter(Collider other2)
	{
		//Detecting Redball and Increasing ScoreCount by 10.
		if (other2.tag == "brownball")
		{
			Destroy(other2.gameObject);
			Debug.Log("Correct blue Ball !!");     //Displaying "Correct Ball" in Console.
			ScoreTrackerNEW.UpdateScore(1);
			ScoreTrackerNEW.UpdateMessage("You Scored 1 point !! ");
		}
	}
}