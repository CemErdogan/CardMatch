using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private Transform context;

    public void Prepare()
    {
        
    }

    public void Select()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
    }

    public void Deselect()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
    }
}
