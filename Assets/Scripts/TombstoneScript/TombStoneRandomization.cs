using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombStoneRandomization : MonoBehaviour
{
    //variables
    public GameObject ghost;
    public GameObject gem;

    [SerializeField] private bool isNear = false;
    
    void Update()
    {
        //if player is near tombstone & player presses 'E'
        if (isNear == true && Input.GetKeyDown(KeyCode.E))
        {
            TombstonePercentage();
        }
    }

    /* 50% chance a ghost appears,
     * 50% chance a gem appears */
    void TombstonePercentage()
    {
        if (Random.value >= 0.5)
        {
            //spawn ghost
            SpawnGhost();

            Debug.Log("Ghost! " + Random.value);
        }

        else if (Random.value < 0.5)
        {
            //spawn gem
            SpawnGem();

            Debug.Log("Gem! "+ Random.value);
        }
    }

    void SpawnGhost()
    {
        InstantiateGameObject(ghost, -1f, 2f, 0f);
    }

    void SpawnGem()
    {
        InstantiateGameObject(gem, -0.0487f, 0.0328f, -0.0082f);
    }

    //instatiate ghost or gem
    void InstantiateGameObject(GameObject prefab, float x, float y, float z)
    {
        //instantiating
        GameObject newPrefab = Instantiate(prefab, new Vector3(0f, 0f, 0f), Quaternion.AngleAxis(-90, Vector3.right)) as GameObject;

        //set position for gem
        newPrefab.transform.localPosition = new Vector3(x, y, z);
    }

    //bool to tell if player is near tombstone or not
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
