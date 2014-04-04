using UnityEngine;
using System.Collections;

public class hudPlace : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<GUITexture>().enabled = true;
		transform.position = new Vector3(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
