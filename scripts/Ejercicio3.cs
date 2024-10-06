using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialObject : MonoBehaviour
{
    public bool isBad = false;
    public Follow itemA;
    public GameObject itemB;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            player.OnObjectCollected(isBad);
            Destroy(gameObject);
            itemB.transform.position = new Vector3(2,1,3);
            itemA.goal = player.transform;
        }
    }
}
