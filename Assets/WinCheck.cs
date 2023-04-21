using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
	private Player depositPlayer;
	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			depositPlayer = other.GetComponent<Player>();
		}
	}

	private void Update() {
		if (depositPlayer && Input.GetKeyDown(KeyCode.E)) {
			if(depositPlayer.Gems >= 10) {
				depositPlayer.AddGem(-10);
				depositPlayer.Win();
			}
		}
	}

	private void OnTriggerExit(Collider other) {
		if (other.CompareTag("Player")) {
			depositPlayer = null;
		}
	}
}
