using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    // reference to parent Pipe GameObject
    public GameObject parentPipe;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bird")
        {
            LogicScript logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
            bool blocked = parentPipe.GetComponent<PipeScript>().blocked;
            if (blocked)
            {
                logicScript.addScore(-1);
                parentPipe.GetComponent<PipeScript>().failedWord();
            }
            else
            {
                logicScript.addScore(1);
            }

        }
    }
}
