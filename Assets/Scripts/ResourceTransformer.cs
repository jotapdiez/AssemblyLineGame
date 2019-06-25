using System.Collections.Generic;
using UnityEngine;

public class ResourceTransformer : MonoBehaviour
{
    public bool debug = false;

    private List<PrimitiveResourceType> collected = new List<PrimitiveResourceType>();

    public GameObject generated;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (collected.Count == 0){
            return;
        }

        PrimitiveResourceType type = collected[0];

        collected.RemoveAt(0);
        float rollerAngle = transform.eulerAngles.z;
        GameObject go = Instantiate(generated, transform.position + Vector3.forward, Quaternion.Euler(transform.eulerAngles));
        go.GetComponent<Resource>().setResourceType(type);
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        PrimitiveResourceType sourceType = target.gameObject.GetComponent<Resource>().GetResourceType();
        collected.Add(sourceType);
        Destroy(target.gameObject);
    }
}
