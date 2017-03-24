using UnityEngine;
using System.Collections;

public class GunKata : MonoBehaviour {

	private Vector3 rotation, start;

	void Start () {
		rotation = Vector3.zero;
		start = transform.eulerAngles;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)){
			rotation.x += 25 * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			rotation.x -= 25 * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			rotation.y -= 25 * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			rotation.y += 25 * Time.deltaTime;
		}
		rotation.x = Mathf.Clamp(rotation.x, -15, 45);
		rotation.y = Mathf.Clamp(rotation.y, -90, 90);
		transform.eulerAngles = start +rotation;
	}


}
