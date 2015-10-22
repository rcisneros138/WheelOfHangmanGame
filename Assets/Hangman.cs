using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Hangman : MonoBehaviour {



    public Text LetterIndicator;

    public string randomWord = "HELLO";           
    private string hiddenWord;            
    public string inputChar;           

    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < randomWord.Length; i++)
        {
            hiddenWord += "-";
        }

        Display();
    }
       
    //Check if the word matches input word
    void CheckChar()
    {
        int charIndex = 0;

        //Search the array of chars of the random string
        for (int i = 0; i < randomWord.Length; i++)
        {
            //Conversion to string is needed for a direct comparing
            if (randomWord[i].ToString() == inputChar)
            {
                //Set the index for each loop pass. Used to set which char need to be replaced
                charIndex = i;

                //Remove character that has been found from
                hiddenWord = hiddenWord.Remove(charIndex, 1);

                //Assign the correct char to the full result string
                hiddenWord = hiddenWord.Insert(charIndex, inputChar);
                

                //Debug.Log("Correct Char: " + hiddenWord[charIndex]);
            }
        }
    }
    void Display()
    {

        //LetterGuess_GameManager manager = new LetterGuess_GameManager();
       
        
        LetterIndicator.text = hiddenWord;

        //inputChar = manager.letter;
        inputChar = GUI.TextField(new Rect(10, 70, 200, 20), inputChar, 1);
        

        if (GUI.Button(new Rect(220, 70, 80, 20), "Submit"))
        {
           
            if (!string.IsNullOrEmpty(inputChar))
                CheckChar();

            
            inputChar = "";
        }
    }
}