using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordList : MonoBehaviour
{
    public List<string> words;
    string pickedWord;
    [SerializeField] Text displayText;


    // Start is called before the first frame update
    void Start()
    {
        PickRandomWords();
        displayText.text = pickedWord;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PickRandomWords()
    {
        pickedWord = words[Random.Range(0, words.Count)];
    }
}
