using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public string pickupName = "Block";

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 60, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject otherObject = other.gameObject;
        if (otherObject.GetComponent<Inventory>())
        {
            otherObject.GetComponent<Inventory>().Pickup(pickupName);
            DestroySelf();
        }
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
