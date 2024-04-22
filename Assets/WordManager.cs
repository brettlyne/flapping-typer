using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    private string[] words;

    void Start()
    {
        TextAsset wordList = Resources.Load<TextAsset>("words");
        words = wordList.text.Split('\n');
    }

    public string GetRandomWord()
    {
        return words[Random.Range(0, words.Length)].ToUpper();
    }
}
