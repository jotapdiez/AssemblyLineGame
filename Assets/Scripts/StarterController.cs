using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterController : MonoBehaviour
{

    public GameObject resource;
    public PrimitiveResource resourceType;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItems", 0.0f, 2.0f);
    }

    void SpawnItems()
    {

        GameObject go = Instantiate(resource, transform.position + Vector3.forward, Quaternion.Euler(transform.eulerAngles));
        // go.transform.position = go.transform.position + new Vector3(0f, 0.45f, 0f);
        go.GetComponent<Resource>().setResourceType(resourceType);
    }

    private void OnMouseDown()
    {
        print("Clicked on starter");
    }
}
