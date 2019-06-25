using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Crafter : MonoBehaviour
{
    public bool debug = false;

    public Dictionary<string, int> collected = new Dictionary<string, int>();

    public CraftRequirement[] requirements;
    public GameObject generated;

    // Start is called before the first frame update
    void Start()
    {
        // foreach (CraftRequirement go in requirements)
        // {
        //     string key = go.obj.name + "_" + go.type;
        //     if (!collected.ContainsKey(key))
        //     {
        //         collected.Add(key, 0);
        //     }
        // }
    }

    // Update is called once per frame
    void Update()
    {
        if (collected.Count == 0){
            return;
        }

        bool enoughMaterials = true;
        foreach(CraftRequirement req in requirements){
            string key = req.obj.name + "_" + req.type;
            if (!collected.ContainsKey(key) || collected[key] < req.count){
                enoughMaterials = false;
                break;
            }
        }

        if (enoughMaterials){
            foreach (CraftRequirement req in requirements)
            {
                string key = req.obj.name + "_" + req.type;
                collected[key] = collected[key]-req.count;
            }
            float rollerAngle = transform.eulerAngles.z;
            Instantiate(generated, transform.position + Vector3.forward, Quaternion.Euler(transform.eulerAngles));
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        string name = target.gameObject.name.Replace("(Clone)", "");
        PrimitiveResourceType type = target.gameObject.GetComponent<Resource>().GetResourceType();
        string key = name + "_" + type;
        if (!collected.ContainsKey(key)){
            collected.Add(key, 0);
        }

        collected[key] = ++collected[key];
        Destroy(target.gameObject);
    }
}
