using UnityEngine;
using System.Collections;

//BFT TODO: Remove this class
public class AlphabetButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public string Letter;
    public string DetectLetter()
    {
        
        if (Input.GetButton("Button A"))
        {
            Letter = "A";
        }
        return Letter;

    }
}
