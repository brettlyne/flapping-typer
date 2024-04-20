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
            logicScript.addScore();

            // get a reference to the script on the parent Pipe GameObject
            // PipeScript pipeScript = parentPipe.GetComponent<PipeScript>();
            // but this makes an error : PipeScript type not found, so instead should be

            // get typedText from parent Pipe GameObject
            TMPro.TextMeshPro typedText = parentPipe.GetComponent<PipeMoveScript>().typedText;
            Debug.Log(typedText.text);


            // PipeScript pipeScript = GetComponent<PipeScript>();
            // if (pipeScript != null && pipeScript.someState) // replace 'someState' with the actual state you want to check
            // {
            //     // Perform some action
            // }
        }
    }
}
