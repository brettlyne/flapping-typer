using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float speed = 5;
    float deadX = -20;

    public TMPro.TextMeshPro typedText;
    public TMPro.TextMeshPro toTypeText;

    void Start()
    {
        typedText.text = "DI";
        toTypeText.text = "DIRT";
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < deadX) {
            Destroy(gameObject);
        }
    }
}
