using UnityEngine;
using System.Collections;

public class TriggerGreen : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other3)
    {
        //Detecting Redball and Increasing ScoreCount by 10.
        if (other3.tag == "greenball")
        {
            Destroy(other3.gameObject);
            Debug.Log("Correct green Ball !!");     //Displaying "Correct Ball" in Console.
            ScoreTrackerNEW.UpdateScore(1);
            ScoreTrackerNEW.UpdateMessage("You Scored 1 point !! ");
        }
    }
}