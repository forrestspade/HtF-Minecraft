using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject lootPrefab;
    private float life = 0.5f;
    private bool isDestroyed = false;
    public void Damage(float damageDealt)
    {
        life -= damageDealt * Time.deltaTime;
        if (life < 0 && isDestroyed == false)
        {
            DestroySelf();
        }
    }

    public void DestroySelf()
    {
        isDestroyed = true;
        GameObject lootObject = Instantiate(lootPrefab, transform.position + new Vector3(0.5f, 0.5f, -0.5f), Quaternion.identity);
        Destroy(gameObject);
    }
}
