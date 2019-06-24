using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PrimitiveResource {
    GOLD=1,
    DIAMOND=2,
    COPPER=3,
    ALUMINIUM=4,
    IRON=5
}

public class Resource : MonoBehaviour
{
    private PrimitiveResource type = 0; //1=Gold, 2=Diamond, 3=Copper

    public float speed = 2f;

    void Start()
    {
        // GetComponent<SpriteRenderer>().color =new Color(0.60f, 0.85f, 0.91f, 1);
    }

    public void setResourceType(PrimitiveResource type){
        this.type = type;

        Color color = Color.black;

        if (type == PrimitiveResource.GOLD){
            color = new Color(0.99f, 0.94f, 0f, 1);
        }else if (type == PrimitiveResource.DIAMOND){
            color = new Color(0.60f, 0.85f, 0.91f, 1);
        }else if (type == PrimitiveResource.COPPER){
            color = new Color(0.72f, 0.39f, 0.23f, 1);
        }else if (type == PrimitiveResource.ALUMINIUM){
            color = new Color(1f, 1f, 1f, 1);
        }else if (type == PrimitiveResource.IRON){
            color = new Color(0.81f, 0.81f, 0.81f, 1);
        }

        if (transform.childCount>0){
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = color;
        }else{
            GetComponent<SpriteRenderer>().color = color;
        }
    }

    public PrimitiveResource GetResourceType(){
        return type;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
