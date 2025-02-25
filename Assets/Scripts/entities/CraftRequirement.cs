using UnityEngine;
using System;

[Serializable]
public class CraftRequirement
{
    [SerializeField]
    public PrimitiveResourceType type;

    [SerializeField]
    public GameObject obj;

    [SerializeField]
    public int count;
}
