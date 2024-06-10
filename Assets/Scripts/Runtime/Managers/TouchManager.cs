using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    [SerializeField] Camera cam;

    void Update()
    {
        GetTouch();
    }

    private void GetTouch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Touch Down");
        }
    }
}
