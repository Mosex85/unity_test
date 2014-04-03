using UnityEngine;
using System.Collections;

public class initMenu : MonoBehaviour {

	public Texture2D texLogo;

	private AsyncOperation async;
	private bool isLoading=false;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(((Screen.width/2) - 150), ((Screen.height/2) - 280), 300,150), texLogo);


		if (!isLoading && GUI.Button(new Rect(((Screen.width/2) - 100), ((Screen.height/2) -100), 200, 50),"GIOCA"))
		{
			isLoading=true;
			async =  Application.LoadLevelAsync("stanza1");
		}

		if (!isLoading && GUI.Button(new Rect(((Screen.width/2) - 100), ((Screen.height/2)), 200, 50),"OPZIONI"))
		{
			Debug.Log("not implemented");
		}

		if (!isLoading && GUI.Button(new Rect(((Screen.width/2) - 100), ((Screen.height/2) + 100), 200, 50),"ESCI"))
		{
			Application.Quit();
		}

		if (async != null)
		{

			Debug.Log(string.Format("{0:N0}%", async.progress * 100f));
			GUI.skin.label.alignment = TextAnchor.MiddleCenter;
			GUI.skin.label.fontStyle = FontStyle.Bold;
			GUI.skin.label.fontSize = 30;
			GUI.skin.label.normal.textColor = Color.black;
			GUI.Label(new Rect(((Screen.width/2) - 150), ((Screen.height/2)), 300, 70), 
			             string.Format("Loading object: {0:N0}%", async.progress * 100f));
		}
		if (Time.time % 2 < 1) {
			GUI.skin.label.alignment = TextAnchor.MiddleCenter;
			GUI.skin.label.fontStyle = FontStyle.Bold;
			GUI.skin.label.fontSize = 25;
			GUI.skin.label.normal.textColor = Color.blue;
			GUI.Label (new Rect ((Screen.width/2) - 200,(Screen.height - 100),400,45), "!!! Development version !!!");
		}
	}
}
