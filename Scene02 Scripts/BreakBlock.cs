using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{
    public float distance = 5;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance, 1 << LayerMask.NameToLayer("Block")))
            {
                GameObject hitObject = hit.collider.gameObject;
                if (hitObject.GetComponent<Block>())
                {
                    hitObject.GetComponent<Block>().DestroySelf();
                }
            }
        }
    }
}
