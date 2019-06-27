using System.Collections.Generic;
using UnityEngine;

public class Splitter : MonoBehaviour
{
    private int nextOutput = 0;

    private List<GameObject> outputs = new List<GameObject>();

    private void Start() {
        for (int i = 0 ; i < transform.childCount ; ++i){
            GameObject child = transform.GetChild(i).gameObject;
            if (child.name.StartsWith("o")){
                outputs.Add(child);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        GameObject output = outputs[nextOutput];

        target.transform.position = output.transform.position;
        target.transform.rotation = output.transform.rotation;

        ++nextOutput;

        if (nextOutput == outputs.Count){
            nextOutput = 0;
        }
    }
}