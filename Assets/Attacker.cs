using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
	IAttribute playerAttribute;
	public float AttackSpeed = 1f;
	public int Damage = 1;
	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			playerAttribute = other.GetComponent<IAttribute>();
			InvokeRepeating("Attack", 0f, AttackSpeed);
		}
	}

	private void Attack() {
		if (playerAttribute == null) {
			CancelInvoke();
			return;
		}
		playerAttribute.Damage(Damage);
	}

	private void OnTriggerExit(Collider other) {
		if (other.CompareTag("Player")) {
			playerAttribute = null;
		}
	}
}
