using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToViewportPoint(Input.mousePosition), Vector2.zero);

        if(hit)
        {
            Debug.Log("hit " + hit.collider.gameObject.name);
        }
    }
}
