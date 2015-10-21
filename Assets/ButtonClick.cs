using UnityEngine;
using System.Collections;

//BFT TODO: Remove this class
public class ButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	 void Update ()
    {

	}

    public void NextPage()
    {

        if (Input.GetButton("ButtonToPuzzle"))
        {
            Application.LoadLevel("LetterGuessScene");
        }
    
    }
    public void ToWheelPage()
    {

        if (Input.GetButton("ButtonToWheel"))
        {
            Application.LoadLevel("UnityCube");
        }

    }
}
