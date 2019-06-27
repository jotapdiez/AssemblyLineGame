using UnityEngine;
using System;
using System.Collections.Generic;

public enum PrimitiveResourceType
{
    GOLD = 1,
    DIAMOND = 2,
    COPPER = 3,
    ALUMINIUM = 4,
    IRON = 5,
}

public class PrimitiveResourceTypeData {

    Texture2D tex = Resources.Load<Texture2D>("Textures/EmptyResource");
    Color color;
    public static PrimitiveResourceType fromString(string type){
        if (type == "GOLD")
        {
            return PrimitiveResourceType.GOLD;
        }
        else if (type == "DIAMOND")
        {
            return PrimitiveResourceType.DIAMOND;
        }
        else if (type == "COPPER")
        {
            return PrimitiveResourceType.COPPER;
        }
        else if (type == "ALUMINIUM")
        {
            return PrimitiveResourceType.ALUMINIUM;
        }

        return PrimitiveResourceType.IRON;
    }

    public PrimitiveResourceTypeData(PrimitiveResourceType type){
        // tex = Resources.Load<Texture2D>("Assets/Textures/EmptyResource");

        if (type == PrimitiveResourceType.GOLD)
        {
            color = new Color(0.99f, 0.94f, 0f, 1);
        }
        else if (type == PrimitiveResourceType.DIAMOND)
        {
            color = new Color(0.60f, 0.85f, 0.91f, 1);
        }
        else if (type == PrimitiveResourceType.COPPER)
        {
            color = new Color(0.72f, 0.39f, 0.23f, 1);
        }
        else if (type == PrimitiveResourceType.ALUMINIUM)
        {
            color = new Color(1f, 1f, 1f, 1);
        }
        else if (type == PrimitiveResourceType.IRON)
        {
            color = new Color(0.81f, 0.81f, 0.81f, 1);
        }
    }

    public Texture2D getTexture(){
        return tex;
    }

    public Texture2D getColoredTexture()
    {
        var fillColorArray = tex.GetPixels();

        for (var i = 0; i < fillColorArray.Length; ++i)
        {
            fillColorArray[i] = color;
        }

        tex.SetPixels(fillColorArray);

        tex.Apply();

        return tex;
    }

    public Color getColor(){
        return color;
    }
}
