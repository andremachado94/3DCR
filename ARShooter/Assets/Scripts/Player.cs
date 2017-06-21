using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

[RequireComponent (typeof (PlayerController))]
[RequireComponent (typeof (GunController))]
public class Player : LivingEntity {
	
	public float moveSpeed = 5;

	//public Crosshairs crosshairs;

	Camera viewCamera;
	PlayerController controller;
	GunController gunController;

	protected override void Start () {
		base.Start ();
		health = startingHealth;
		gunController.EquipGun (0);
	}

	void Awake() {
		controller = GetComponent<PlayerController> ();
		gunController = GetComponent<GunController> ();
		viewCamera = Camera.main;
		//FindObjectOfType<Spawner> ().OnNewWave += OnNewWave;
	}
/*
	void OnNewWave(int waveNumber) {
		health = startingHealth;
		gunController.EquipGun (waveNumber - 1);
	}
*/
	void FixedUpdate(){
		controller.Move ();
	}

	void Update () {

		// Weapon input
		if (CnInputManager.GetButton("Jump")) {
			gunController.OnTriggerHold();
		}
		if (CnInputManager.GetButtonUp("Jump")) {
			gunController.OnTriggerRelease();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			gunController.Reload();
		}

		/*
		if (transform.position.y < -10) {
			TakeDamage (health);
		}
		*/
	}

	public override void Die ()
	{
		//AudioManager.instance.PlaySound ("Player Death", transform.position);
		base.Die ();
	}

}