using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyedShips : MonoBehaviour {

	public Text shipsDestroyed;
	public int kills = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		shipsDestroyed.text = "Kills: " + kills.ToString ();
	}
}
