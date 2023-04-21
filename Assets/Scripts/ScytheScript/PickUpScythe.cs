using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScythe : MonoBehaviour
{
    //variables
    private GameObject player;
    private IDamager damager;
    [SerializeField] private bool isNear = false;

    private void Awake()
    {
        //finds player
        player = FindObjectOfType<PlayerMovement>().gameObject;
        damager = GetComponent<IDamager>();
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
            player.GetComponent<Player>().EnableMeleeWeapon();
            gameObject.SetActive(false);
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
