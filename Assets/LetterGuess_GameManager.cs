using UnityEngine;
using System.Collections;

public class LetterGuess_GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ToLetterGuessPage_ButtonClick()
    {

        if (Input.GetButton("ButtonToPuzzle"))
        {
            Application.LoadLevel("LetterGuessScene");
        }
    }

    public void ToWheelPage_ButtonClick()
    {

        if (Input.GetButton("ButtonToWheel"))
        {
            
            Application.LoadLevel("WheelSpinScene");
        }

    }

    
    public void Letter_ButtonClick(string letter)
    {
        GameObject.Find("GameController").GetComponent<Hangman>().CheckInput(letter[0]);
        //GameObject.Find("GameController").GetComponent<Hangman>().AddToScore(letter[0]);
    }


}
