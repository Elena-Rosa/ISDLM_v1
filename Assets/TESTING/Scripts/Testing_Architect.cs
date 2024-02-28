using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour

    {
        DialogueSystem ds;
        TextArchitect architect;

        string[] lines = new string[6]
        {
        "Hi, where do I begin",
        "and where do I end",
        "with her, or with me",
        "somewhere",
        "It's nice to meet you in here",
        "I'll see you around..."
        };


        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.instant;

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                architect.Build(lines[Random.Range(0, lines.Length)]);
        }
    }
}


