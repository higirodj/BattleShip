using UnityEngine;
using System.Collections;


public class Fire : MonoBehaviour {
	
	public Transform sightPost;
	public Transform missileSightPost;
	public AudioClip gun_noise;
	public AudioClip torpedo_noise;
	public GameObject projectile;
	public GameObject torpedoProjectile;

	private float projectileSpeed;
	private float torpedoSpeed;
	private int ammo;
	private int missile;
	public int roundsFired;


	//private int maxAmmo;

	void Start(){
		missile = 20;
		ammo = 100;
		torpedoSpeed = 350.0f; 
		projectileSpeed = 150.0f;
		roundsFired = 1;
	
	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			
			if (ammo > 0) {
				fireBullets (sightPost);
				ammo -= roundsFired;

			}
		}

		if (Input.GetKeyDown (KeyCode.M)) {

			if (missile > 0) {
				fireTorpedos (missileSightPost);
				missile -= roundsFired;

			}
		}
	}
		
	void fireBullets(Transform origin){

		GetComponent<AudioSource>().PlayOneShot (gun_noise, 1.0f);
		GameObject bulletsInstance;
		bulletsInstance = Instantiate (projectile, origin.position, origin.rotation) as GameObject;
		Rigidbody rg = bulletsInstance.GetComponent<Rigidbody> ();
		rg.velocity = transform.TransformDirection (-Vector3.forward * projectileSpeed);
		Destroy (bulletsInstance, 5f);

	}

	void fireTorpedos(Transform origin){

		GetComponent<AudioSource>().PlayOneShot (torpedo_noise, 1.0f);
		GameObject torpedoInstance;
		torpedoInstance = Instantiate (torpedoProjectile, origin.position, origin.rotation) as GameObject;
		Rigidbody rg = torpedoInstance.GetComponent<Rigidbody> ();
		rg.velocity = transform.TransformDirection (-Vector3.forward * torpedoSpeed);
		Destroy (torpedoInstance, 5f);

	}

	void OnGUI() {
		GUI.Box(new Rect(0, 10, 200, 25),"Turret Ammo: " + ammo.ToString());
		GUI.Box(new Rect(0, 40, 200, 25),"Missiles: " + missile.ToString());
	}

}
