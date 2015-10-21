using UnityEngine;
using System.Collections;

public class LetterGuess_GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToWheelPage_ButtonClick()
    {

        if (Input.GetButton("ButtonToWheel"))
        {
            //BFT TODO: Rename this scene
            Application.LoadLevel("UnityCube");
        }

    }

    public string letter;
    public void Letter_ButtonClick(string letter)
    {
        this.letter = letter;
        //BFT TODO: Now that you're done with this test, remove the dead code
        Debug.Log(letter);   
       // Application.LoadLevel("UnityCube");
          

    }


}
