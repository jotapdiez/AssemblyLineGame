using UnityEngine;
using System;

[System.Serializable]
public class CraftRequirement
{
    [SerializeField]
    public PrimitiveResourceType type;

    [SerializeField]
    public GameObject obj;

    [SerializeField]
    public int count;
}
