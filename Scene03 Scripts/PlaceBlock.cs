using UnityEngine;
public class PlaceBlock : MonoBehaviour
{
    public Inventory inventory;
    public float distance = 5;
    public string blockName = "Block";

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance, 1 << LayerMask.NameToLayer("Block")))
            {
                Vector3 closerPoint = hit.point - (transform.forward * 0.01f);
                Vector3 roundedPoint = new Vector3(Mathf.Floor(closerPoint.x), Mathf.Floor(closerPoint.y), Mathf.Ceil(closerPoint.z));
                GameObject blockToPlace = inventory.Place(blockName);
                if (blockToPlace != null)
                {
                    Instantiate(blockToPlace, roundedPoint, Quaternion.identity);
                }
            }
        }
    }
}
