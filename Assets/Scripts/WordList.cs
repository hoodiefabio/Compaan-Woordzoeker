using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordList : MonoBehaviour
{
    public List<string> words;
    List<string> pickedWords;
    [SerializeField] Text displayText;


    // Start is called before the first frame update
    void Start()
    {
        
        foreach (string word in words)
        {
            displayText.text = displayText.text + "\n" + word;
        }
    }
    

    // Update is called once per frame
    void Update()
    {

    }

    void PickRandomWords()
    {
       // pickedWords.Add(words[Random.Range(0, words.Count)]);
       
    }
}
