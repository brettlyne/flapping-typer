using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float speed = 5;
    float deadX = -20;

    public TMPro.TextMeshPro typedText;
    public TMPro.TextMeshPro toTypeText;
    private string[] words;
    int letterIndex = 0;
    public bool blocked = true;

    void Start()
    {
        TextAsset wordList = Resources.Load<TextAsset>("words");
        words = wordList.text.Split('\n');
        typedText.text = "";
        toTypeText.text = words[Random.Range(0, words.Length)].ToUpper();
    }
    void Update()
    {
        // move the pipe to the left
        transform.position += Vector3.left * speed * Time.deltaTime;
        // destroy the pipe if it goes off screen
        if (transform.position.x < deadX)
        {
            Destroy(gameObject);
        }
        // check if the player has typed the correct letter
        if (Input.anyKeyDown && blocked)
        {
            string keyPressed = Input.inputString.ToUpper();
            if (keyPressed == toTypeText.text[letterIndex].ToString().ToUpper())
            {
                typedText.text += toTypeText.text[letterIndex];
                letterIndex++;
                if (letterIndex == toTypeText.text.Length)
                {
                    blocked = false;
                }
            }
        }
    }

    public void failedWord()
    {
        toTypeText.color = Color.red;
    }
}
