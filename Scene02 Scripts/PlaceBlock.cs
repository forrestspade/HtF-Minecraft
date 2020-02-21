using UnityEngine;
public class PlaceBlock : MonoBehaviour
{
    public GameObject blockPrefab;
    public float distance = 5;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance, 1 << LayerMask.NameToLayer("Block")))
            {
                Vector3 closerPoint = hit.point - (transform.forward * 0.01f);
                Vector3 roundedPoint = new Vector3(Mathf.Floor(closerPoint.x), Mathf.Floor(closerPoint.y), Mathf.Ceil(closerPoint.z));
                Instantiate(blockPrefab, roundedPoint, Quaternion.identity);
            }
        }
    }
}
