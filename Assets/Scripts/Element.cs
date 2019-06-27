using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Element : MonoBehaviour
{
    public bool active = true;

    public void RotateCW(){
        transform.Rotate(new Vector3(0, 0, 1), 90f);
    }

    public void RotateCCW(){
        transform.Rotate(new Vector3(0, 0, 1), -90f);
    }

    public void ToggleActive(){
        active = !active;
    }

    public void Activate(){
        active = true;
    }
    public void Deactivate(){
        active = false;
    }

    public bool isActive(){
        return active;
    }
}