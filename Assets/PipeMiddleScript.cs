using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bird")
        {
            LogicScript logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
            logicScript.addScore();
        }
    }
}
