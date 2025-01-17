using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
	private IDamager equippedMelee;
	public Transform equippedMeleeParent;
	public GameObject meleeWeapon;
	public int Gems;
	public TextMeshProUGUI gemCount;
	public GameObject WinScreen;
	public GameObject LoseScreen;

	public DetermineGameStart gameStatus;


	private void Start() {

		gameStatus.gameStart = false;

		if (gameStatus.gameStart == true)
        {
			Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = false;
			AddGem();
		}
	}

	public void EnableMeleeWeapon() {
		equippedMelee = meleeWeapon.GetComponent<IDamager>();
		meleeWeapon.SetActive(true);
	}

	public void Win() {
		WinScreen.SetActive(true);
		Time.timeScale = 0;
		gameStatus.GameHasEnded();
	}

	public void Lose() {
		LoseScreen.SetActive(true);
		Time.timeScale = 0;
		gameStatus.GameHasEnded();
	}

	private void Update() {
		if (Input.GetMouseButtonDown(0) && equippedMelee) {
			//Debug.Log("attacking");
			equippedMelee.MeleeAttack();
		}
	}

	public void AddGem(int _amount = 0) {
		Gems += _amount;
		gemCount.text = Gems.ToString();
	}
}
