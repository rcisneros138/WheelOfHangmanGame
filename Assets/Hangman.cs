using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Hangman : MonoBehaviour {

    public Text WordIndicator;
    public Text LettersIndicator;

    public string word;
    public char[] revealed;
    public int score;
    public bool completed;

    public Hangman hangman;


	// Use this for initialization
	void Start ()
    {
        hangman = GameObject.FindGameObjectWithTag("Player").GetComponent<Hangman>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void updateWordIndicator()
    {
        string displayed = "";
        for (int i = 0; i < revealed.Length; i++)
        {
            char revealedChar = revealed[i];
            if (revealedChar == 0)
            {
                revealedChar = '_';
            }

            displayed = displayed + ' ';
            displayed = displayed + revealedChar;
        }
        WordIndicator.text = displayed;
    }
    public void SetWord(string word)
    {
        this.word = word;
        revealed = new char[word.Length];
        LettersIndicator.text = " " + word.Length;

        updateWordIndicator();

    }
    public void next()
    {
        SetWord("Hello");
    }
    public void reset()
    {
        score = 0;
        completed = false;
        next();
    }
}
