using UnityEngine;
using System.Collections;

public class hitRcvChangeColor : MonoBehaviour {

	public Color colorStart = new Color(0, 255, 0, 255);
	public Color colorEnd = new Color(28, 135, 64, 255);
	public float duration = 0.5F;
	
	Color colorOrig;
	bool mouseHit = false;

	void Start () {
		colorOrig = this.renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		this.renderer.material.color = colorOrig;
		mouseHit = false;
	}

	void HitByRaycast(GameObject source)
	{
		float lerp = Mathf.PingPong(Time.time, duration) / duration;
		this.renderer.material.color = Color.Lerp(colorStart, colorEnd, lerp);
		mouseHit = true;
	}

	void OnGUI() 
	{
		if (mouseHit) 
		{
			Vector3 screenPosition = Camera.current.WorldToScreenPoint (transform.position);


			screenPosition.y = Screen.height/2;
			screenPosition.y = Screen.height - (screenPosition.y + 1);// inverts y

			screenPosition.x = Screen.width/2;
			
			Rect rect = new Rect (screenPosition.x , screenPosition.y , 80, 30);// makes a rect centered at the player ( 100x24 )
			
			GUI.Box (rect, renderer.tag.ToString());
		}
	}
}
