using UnityEngine;
using System.Collections;

public class quitEscape : MonoBehaviour {
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}
}
