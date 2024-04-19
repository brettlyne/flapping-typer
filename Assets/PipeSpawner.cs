using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2;
    private float timer = 0;
    public float yOffset = 4.3f;

    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
        float y = Random.Range(-yOffset, yOffset) + transform.position.y;
        Instantiate(pipePrefab, new Vector3(transform.position.x, y, transform.position.z), transform.rotation);
    }


}
