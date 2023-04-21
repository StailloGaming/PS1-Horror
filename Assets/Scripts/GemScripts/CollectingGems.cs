using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingGems : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player)
        {
            player.AddGem(1); ;
            Destroy(gameObject);
            Debug.Log("Collected a gem!");
        }
    }

}
