using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] string collisionTag;

    void Update()
    {
        GetTouch(Input.mousePosition);
    }
    
    private void GetTouch(Vector3 pos)
    {
        if (Input.GetMouseButtonDown(0))
        {
            var hit = Physics2D.OverlapPoint(cam.ScreenToWorldPoint(pos));
            if (CanTouch(hit))
            {
                Debug.Log(hit.gameObject.name, hit.gameObject);
            }
        }
    }

    private bool CanTouch(Collider2D hit)
    {
        return hit != null && hit.CompareTag(collisionTag);
    }
}
