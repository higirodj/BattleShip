using UnityEngine;
using System.Collections;

public class ShipMakerOne : MonoBehaviour {

	public GameObject ShipToSpawn;
	private int totalToSpawn = 20;
	private float spawnInterval = 25.0f;

	// Use this for initialization
	void Start () {

		StartCoroutine (MyCoroutine(totalToSpawn));

	}

	IEnumerator MyCoroutine(int totalToSpawn) {

		for (int i = 0; i < totalToSpawn; i++) {
			Vector3 position = new Vector3(1035, 400, -850);
			Instantiate(ShipToSpawn, position, Quaternion.identity);
			yield return new WaitForSeconds(spawnInterval);
		}

	}

}
