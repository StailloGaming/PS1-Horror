using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScythe : MonoBehaviour
{
    //variables
    private GameObject player;
    [SerializeField] private bool isNear = false;

    private void Awake()
    {
        //finds player
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (isNear == true)
        {
            PickUp();
        }
    }

    private void PickUp()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //scythe's parent is player's position
            gameObject.transform.parent = player.transform;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isNear = false;
    }
}
