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
            var hit = Physics2D.OverlapPoint(cam.ScreenToWorldPoint(pos)) as BoxCollider2D;
            if (hit != null && hit.CompareTag(collisionTag))
            {
                Debug.Log(hit.gameObject.name, hit.gameObject);
            }
        }
    }
}
