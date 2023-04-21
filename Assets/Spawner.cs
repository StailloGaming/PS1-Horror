using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public Vector2 RandomSpawnTime;
    
    void Start(){
        Invoke("Spawn", Random.Range(RandomSpawnTime.x, RandomSpawnTime.y));
    }

	private void Spawn() {
        int _random = Random.Range(0, Enemies.Length);
        Instantiate(Enemies[_random], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(RandomSpawnTime.x, RandomSpawnTime.y));
    }
}
