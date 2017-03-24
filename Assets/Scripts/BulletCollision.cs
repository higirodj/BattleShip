using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

	public GameObject explosionPrefab;
	GameObject gm;
	void Start() {

		gm = GameObject.FindWithTag("Manager");
	}

	void OnCollisionEnter(Collision collision) {
		
		if (collision.gameObject.tag == "ship1" ||
		    collision.gameObject.tag == "ship2" ||
		    collision.gameObject.tag == "ship3") {

			ContactPoint contact = collision.contacts [0];
			Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			GameObject explosion = Instantiate (explosionPrefab, pos, rot) as GameObject;
			Destroy (explosion, 10.0f);
			collision.gameObject.GetComponent<BoxCollider>().enabled = false;
			DestroyedShips ds = gm.GetComponent<DestroyedShips>();
			ds.kills = ds.kills+1;
			Destroy (collision.gameObject, 2.0f);
			Destroy (this.gameObject);
		}

	}

}
