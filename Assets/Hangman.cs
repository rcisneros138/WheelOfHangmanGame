using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Hangman : MonoBehaviour {


    
    public Text LetterIndicator;
    public Text ScoreIndicator;


    public string randomWord;          
    public string hiddenWord;
    public bool match;
    public bool won;
    public int Player1Score;
    public string oldHiddenWord;
    public List<char> guessedLetters;
            
    

    // Use this for initialization

   public void ChooseWord()
    {

    }
   public void Start()
    {

        randomWord = "HELLO";
        Player1Score = 6;

        for (int i = 0; i < randomWord.Length; i++)
        {
            hiddenWord += "-";
        }
        LetterIndicator.text = hiddenWord;
        ScoreIndicator.text = "Player 1 Score: " + Player1Score.ToString();
    }
    //Check if the word matches input word
    public void ReplaceDashWithCharacter(char userInput)
    {
        int charIndex = 0;
        AddToScore(userInput);
        for (int i = 0; i < randomWord.Length; i++)
        {
            if (randomWord[i] == userInput)
            {
                Player1Score++;
                charIndex = i;
                hiddenWord = hiddenWord.Remove(charIndex, 1);
                hiddenWord = hiddenWord.Insert(charIndex, userInput.ToString());

            }
               
        }

        
        LetterIndicator.text = hiddenWord;
        ScoreIndicator.text = "Player 1 Score: " + Player1Score.ToString();
        //AddToScore();
    }
    public void AddToScore(char userInput)
    {
        guessedLetters.Add(userInput);
        if (guessedLetters.Contains(userInput))
        {
            
        }
        
    }
}