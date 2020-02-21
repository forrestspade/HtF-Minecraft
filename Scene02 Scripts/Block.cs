using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private bool isDestroyed = false;

    public void DestroySelf()
    {
        if (isDestroyed == false)
        {
            isDestroyed = true;
            Destroy(gameObject);
        }
    }
}
