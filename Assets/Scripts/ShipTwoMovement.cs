using UnityEngine;
using System.Collections;

public class ShipTwoMovement : MonoBehaviour {

	private float floatSpeed;
	private bool hit;

	// Use this for initialization
	void Start () {
		floatSpeed = 35;
		hit = false;
	}

	// Update is called once per frame
	void Update () {
		if (hit == true) {
			transform.position += transform.forward * floatSpeed * Time.deltaTime;
		} else {
			transform.position += transform.forward * floatSpeed * Time.deltaTime;
			transform.position = new Vector3 (transform.position.x, 601.0f, transform.position.z);
			Destroy (this.gameObject, 50);
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Bullet" ||
			collision.gameObject.tag == "Missile") {
			hit = true;
		}
	}
}
