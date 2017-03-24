using UnityEngine;
using System.Collections;

public class WatchTowerView : MonoBehaviour {

	private Vector3 start, rotation;

	void Start () {
		start = transform.eulerAngles;
		rotation = Vector3.zero;

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)){
			rotation.x -= 25 * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			rotation.x += 25 * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			rotation.y -= 25 * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			rotation.y += 25 * Time.deltaTime;
		}
		rotation.x = Mathf.Clamp(rotation.x, -25, 25);
		rotation.y = Mathf.Clamp(rotation.y, -180, 180);
		transform.eulerAngles = (start + rotation);
	}


}
