using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate;
    private float timer = 0;
    public float yOffset;
    private string[] words;

    void Start()
    {
        words = System.IO.File.ReadAllLines(Application.dataPath + "/scripts/words.txt");
        spawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float y = Random.Range(-yOffset, yOffset) + transform.position.y;
        Instantiate(pipePrefab, new Vector3(transform.position.x, y, transform.position.z), transform.rotation);
    }


}
