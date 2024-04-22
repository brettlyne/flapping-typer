using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float speed = 5;
    float deadX = -20;

    public TMPro.TextMeshPro typedText;
    public TMPro.TextMeshPro toTypeText;
    private string[] words;

    void Start()
    {
        words = System.IO.File.ReadAllLines(Application.dataPath + "/scripts/words.txt");
        typedText.text = "";
        toTypeText.text = words[Random.Range(0, words.Length)].ToUpper();
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < deadX)
        {
            Destroy(gameObject);
        }
    }
}
