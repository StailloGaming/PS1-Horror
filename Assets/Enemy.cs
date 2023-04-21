using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	private NavMeshAgent navMeshAgent;
	private GameObject player;
	private void Awake() {
		navMeshAgent = GetComponent<NavMeshAgent>();
		Player _player = FindFirstObjectByType<Player>();
		if (_player) player = _player.gameObject;
	}
	private void OnEnable() {
		InvokeRepeating("AttackPlayer", 0f, .3f);
	}

	private void AttackPlayer() {
		if (!navMeshAgent.isOnNavMesh) {
			return;
		}
		if (player) navMeshAgent.SetDestination(player.transform.position);
	}
}
