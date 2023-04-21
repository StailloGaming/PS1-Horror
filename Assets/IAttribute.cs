using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IAttribute : MonoBehaviour
{
	private int currentHealth;
	public int MaxHealth;
	public Slider Slider;
	public GameObject[] Loot;
	[Range(0, 100)] public int LootChance = 50;
	private Player player;

	private void Start() {
		currentHealth = MaxHealth;

		player = GetComponent<Player>();
	}

	public void Damage(int _damage) {
		currentHealth -= _damage;
		if (Slider) Slider.value = ((float)currentHealth / MaxHealth);
		if (currentHealth <= 0) {
			Kill();
		}
	}

	private void Kill() {
		int _random = Random.Range(0, 101);
		if(Loot.Length > 0 && _random < LootChance) {
			Instantiate(Loot[Random.Range(0, Loot.Length)], transform.position, Quaternion.identity);
		}
		if (player) player.Lose();
		if (!player) Destroy(gameObject);
	}
}
