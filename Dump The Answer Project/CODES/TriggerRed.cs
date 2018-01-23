using UnityEngine;
using System.Collections;

public class TriggerRed : MonoBehaviour
{
	

    // Use this for initialization
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        //Detecting Redball and Increasing ScoreCount by 10.
        if (other.tag == "redball")
        {
            Destroy(other.gameObject);
            Debug.Log("Correct RED Ball !!");     //Displaying "Correct Ball" in Console.
            ScoreTrackerNEW.UpdateScore(1);
            ScoreTrackerNEW.UpdateMessage("You Scored 1 point !! ");

				
        }
        
    }
}