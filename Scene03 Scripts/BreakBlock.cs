using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{
    public GameObject particles;
    private float distance = 5;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance, 1 << LayerMask.NameToLayer("Block")))
            {
                GameObject hitObject = hit.collider.gameObject;
                if (hitObject.GetComponent<Block>())
                {
                    hitObject.GetComponent<Block>().Damage(1);
                    GameObject.Instantiate(particles, hit.point, Quaternion.Euler(-90, 0, 0));
                }
            }
        }
    }
}
