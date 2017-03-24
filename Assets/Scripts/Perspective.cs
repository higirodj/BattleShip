using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Perspective : MonoBehaviour {

	public GameObject view1;
	public GameObject view2;
	public GameObject gun1;
	public GameObject gun2;
	public GameObject gun3;
	public GameObject gun4;
	public GameObject gun5;
	public GameObject gun6;
	public Text viewpoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (view1.activeInHierarchy) {
			viewpoint.text = "Watch Post 1";
		}

		if (view2.activeInHierarchy) {
			viewpoint.text = "Watch Post 2";
		}

		if (Input.GetKeyDown (KeyCode.Alpha1)) {

			viewpoint.text = "Gun Turret 1";
			gun1.SetActive (true);
			gun2.SetActive (false);
			gun3.SetActive (false);
			gun4.SetActive (false);
			gun5.SetActive (false);
			gun6.SetActive (false);
			view1.SetActive (false);
			view2.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) {

			viewpoint.text = "Gun Turret 2";
			gun2.SetActive (true);
			gun1.SetActive (false);
			gun3.SetActive (false);
			gun4.SetActive (false);
			gun5.SetActive (false);
			gun6.SetActive (false);
			view1.SetActive (false);
			view2.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {

			viewpoint.text = "Gun Turret 3";
			gun3.SetActive (true);
			gun1.SetActive (false);
			gun2.SetActive (false);
			gun4.SetActive (false);
			gun5.SetActive (false);
			gun6.SetActive (false);
			view1.SetActive (false);
			view2.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha4)) {

			viewpoint.text = "Gun Turret 4";
			gun4.SetActive (true);
			gun1.SetActive (false);
			gun2.SetActive (false);
			gun3.SetActive (false);
			gun5.SetActive (false);
			gun6.SetActive (false);
			view1.SetActive (false);
			view2.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha5)) {

			viewpoint.text = "Gun Turret 5";
			gun5.SetActive (true);
			gun1.SetActive (false);
			gun2.SetActive (false);
			gun3.SetActive (false);
			gun4.SetActive (false);
			view1.SetActive (false);
			gun6.SetActive (false);
			view2.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.Alpha6)) {

			viewpoint.text = "Gun Turret 6";
			gun6.SetActive (true);
			gun1.SetActive (false);
			gun2.SetActive (false);
			gun3.SetActive (false);
			gun4.SetActive (false);
			gun5.SetActive (false);
			view1.SetActive (false);
			view2.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.O)) {
			
			view1.SetActive (true);
			view2.SetActive (false);
			gun1.SetActive (false);
			gun2.SetActive (false);
			gun3.SetActive (false);
			gun4.SetActive (false);
			gun5.SetActive (false);
			gun6.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.P)) {

			viewpoint.text = "Watch Post 2";
			view2.SetActive (true);
			view1.SetActive (false);
			gun1.SetActive (false);
			gun2.SetActive (false);
			gun3.SetActive (false);
			gun4.SetActive (false);
			gun5.SetActive (false);
			gun6.SetActive (false);
		}
			
	}
}
