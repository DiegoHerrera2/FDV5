using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public bool isBad = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected!");
        if (other.gameObject.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            player.OnObjectCollected(isBad);
            Destroy(gameObject);
        }
    }
}
