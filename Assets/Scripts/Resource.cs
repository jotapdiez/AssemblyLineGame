using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    private PrimitiveResourceType type = 0;
    public float speed = 2f;

    void Start()
    {
        // GetComponent<SpriteRenderer>().color =new Color(0.60f, 0.85f, 0.91f, 1);
    }

    public void setResourceType(PrimitiveResourceType type){
        this.type = type;

        Color color = Color.black;

        if (type == PrimitiveResourceType.GOLD){
            color = new Color(0.99f, 0.94f, 0f, 1);
        }else if (type == PrimitiveResourceType.DIAMOND){
            color = new Color(0.60f, 0.85f, 0.91f, 1);
        }else if (type == PrimitiveResourceType.COPPER){
            color = new Color(0.72f, 0.39f, 0.23f, 1);
        }else if (type == PrimitiveResourceType.ALUMINIUM){
            color = new Color(1f, 1f, 1f, 1);
        }else if (type == PrimitiveResourceType.IRON){
            color = new Color(0.81f, 0.81f, 0.81f, 1);
        }

        if (transform.childCount>0){
            transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = color;
        }else{
            GetComponent<SpriteRenderer>().color = color;
        }
    }

    public PrimitiveResourceType GetResourceType(){
        return type;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
