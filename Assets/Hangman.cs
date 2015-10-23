using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Hangman : MonoBehaviour {


    
    public Text LetterIndicator;
    public Text ScoreIndicator1;
    public Text ScoreIndicator2;
    public Text LettersUsed;

    public string randomWord;
    public string lowercaseRandomWord;        
    public string hiddenWord;
    public bool match;
    public bool won;
    public int Player1Score;
    public int player2Score;
    public int playerID =1;
    public string oldHiddenWord;
    public bool letterReused;
    public string wordBank;
    public List<char> guessedLetters;
            
   public void Start()
    {
        randomWord = "";
        hiddenWord = "";
        GetWord();
        Player1Score = 0;
        player2Score = 0;
        for (int i = 0; i < randomWord.Length; i++)
        {
            hiddenWord += "-";
        }
        LetterIndicator.text = hiddenWord;
        ScoreIndicator1.text = "Player 1 Score: " + Player1Score.ToString();
        ScoreIndicator2.text = "Player 2 Score: " + player2Score.ToString();
    }
    public void CheckInput(char userInput)
    {
        CheckIfAlreadyGuessed(userInput);

    }

    public void ReplaceDashesWithCharacters(char userInput)
    {
        int charIndex = 0;
        
        for (int i = 0; i < randomWord.Length; i++)
        {
            if (randomWord[i] == userInput)
            {
                AddToScore();
                charIndex = i;
                hiddenWord = hiddenWord.Remove(charIndex, 1);
                hiddenWord = hiddenWord.Insert(charIndex, userInput.ToString());
            }
        }
        if (playerID == 1)
        {
            playerID = 2;
        }
        else if (playerID == 2)
        {
            playerID = 1;
        }
        LetterIndicator.text = hiddenWord;
        ScoreIndicator1.text = "Player 1 Score: " + Player1Score.ToString();
        ScoreIndicator2.text = "Player 2 Score: " + player2Score.ToString();
    }
    
    public void CheckIfAlreadyGuessed(char userInput)
    {
        if (guessedLetters.Contains(userInput))
        {
           //hang here put pop up window
        }
        else
        {
            guessedLetters.Add(userInput);
            ReplaceDashesWithCharacters(userInput);
        }  

    }

    public void AddToScore()
    {
        if (playerID == 1)
        {
            Player1Score++;
        }
        if (playerID == 2)
        {
            player2Score++;
        }

    }
    public void GetWord()
    {
        wordBank = System.IO.File.ReadAllText("C:/Users/rcisneros_be/Documents/cities.txt");
        string[] words = wordBank.Split('\n');
        lowercaseRandomWord = words[Random.Range(0, words.Length)];
        randomWord = lowercaseRandomWord.ToUpper();
       
        randomWord.TrimEnd('\r');
        hiddenWord.TrimEnd('\n');

        //Debug.Log("Yolo"+randomWord+"Yolo");

    }

    
}