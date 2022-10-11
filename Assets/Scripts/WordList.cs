using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class WordList : MonoBehaviour
{
    public List<string> words;
    public int amountOfWords = 3;
    [SerializeField] Text displayText;
    



    // Start is called before the first frame update
    void Start()
    {
        //Big pool of words to choose from
        words.Add("koets"); words.Add("synergie");
        words.Add("water"); words.Add("koffie");
        words.Add("paard"); words.Add("schilder");
        words.Add("sport"); words.Add("leraar");
        words.Add("geluid"); words.Add("regen");
        words.Add("klein"); words.Add("systeem");
        words.Add("horizon"); words.Add("praten");
        words.Add("hand"); words.Add("boom");
        words.Add("storm"); words.Add("boos");
        words.Add("behang"); words.Add("gevaar");
        words.Add("spiegel"); words.Add("stoel");

        PickRandomWords(amountOfWords);
    }
    

    void PickRandomWords(int amount)
    {

        for (int i = 0; i < words.Count; i++)
        {
            string temp = words[i];
            int randomIndex = Random.Range(i, words.Count);
            words[i] = words[randomIndex];
            words[randomIndex] = temp;
        }

        for (int i = 0; i < amount; i++)
        {
            displayText.text = displayText.text + "\n" + words[i];
           //add function to place word in grid
        }
    }
}
