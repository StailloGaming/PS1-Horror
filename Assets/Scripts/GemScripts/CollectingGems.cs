using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingGems : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Collected a gem!");
        }
    }

}
