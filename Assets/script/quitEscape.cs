using UnityEngine;
using System.Collections;

public class quitEscape : MonoBehaviour {

	private MouseLook ms1, ms2;
	private mirino mir;

	private GameObject gobj, escText;
	private bool isPaused = false;

	private GUITexture tex;

	void Start()
	{
		ms1 = (MouseLook)GetComponent<MouseLook>();
		mir = (mirino)GetComponent<mirino>();

		gobj = GameObject.FindGameObjectWithTag("Player");
		ms2 = (MouseLook)gobj.GetComponent<MouseLook>();

		escText = GameObject.Find("escTexture");

		tex = (GUITexture)escText.GetComponent<GUITexture>();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)){

			if(isPaused == false) {
				ChangeState(false);

				Application.Quit(); // FIX
			} else {
				ChangeState(true);
			}
		}
	}

	void ChangeState(bool b)
	{
		Screen.showCursor = !b;
		ms1.enabled = b;
		mir.enabled = b;
		ms2.enabled = b;
		tex.enabled = !b;

		isPaused = !isPaused;
	}
}
