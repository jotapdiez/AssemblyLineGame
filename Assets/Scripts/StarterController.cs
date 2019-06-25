using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterController : Element
{
    // public GameObject menu;

    public GameObject resource;
    public PrimitiveResourceType resourceType;

    [RangeAttribute(1,5)]
    public int SpawnCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItems", 0.0f, 2.0f);
    }

    void SpawnItems()
    {
        if (isActive()){
            for (int i = 0 ; i<SpawnCount ; ++i){
                GameObject go = Instantiate(resource, transform.position + Vector3.forward, Quaternion.Euler(transform.eulerAngles));
                go.GetComponent<Resource>().setResourceType(resourceType);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Debug.Log("OnTriggerStay2D::name= " + other.name);
        other.transform.Translate(Vector3.down * 2f * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            RotateCCW();
        // if (Input.GetMouseButtonDown(1))
        //     RotateCW();
        // GameObject go = Instantiate(menu, transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        // GameObject go = Instantiate(menu, transform.position, Quaternion.identity);
        // go.SetActive(true);
        // go.transform.position = transform.position;

        // menu.SetActive(true);
        // menu.transform.position = transform.position;
    }
}
