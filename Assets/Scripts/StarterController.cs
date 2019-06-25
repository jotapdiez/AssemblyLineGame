using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterController : MonoBehaviour
{
    // public GameObject panel;

    public bool active = true;

    public GameObject resource;
    public PrimitiveResourceType resourceType;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItems", 0.0f, 2.0f);
    }

    void SpawnItems()
    {
        if (active){
            GameObject go = Instantiate(resource, transform.position + Vector3.forward, Quaternion.Euler(transform.eulerAngles));
            // go.transform.position = go.transform.position + new Vector3(0f, 0.45f, 0f);
            go.GetComponent<Resource>().setResourceType(resourceType);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Debug.Log("OnTriggerStay2D::name= " + other.name);
        other.transform.Translate(Vector3.down * 2f * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        // panel.SetActive(true);
        // panel.transform.position = transform.position;
    }
}
