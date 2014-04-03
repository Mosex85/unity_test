using UnityEngine;
using System.Collections;

public class mirino : MonoBehaviour {

	public Texture2D crosshairImageNormal;
	public Texture2D crosshairImageOnHit;

	private RaycastHit hit;
	private bool isHit=false;

	void Start () {
		Screen.showCursor = false;
	}

	void Update () {
		Transform cam = Camera.main.transform;
		
		Ray ray = new Ray(cam.position, cam.forward);
		
		if (Physics.Raycast(ray, out hit, 1))
		{
			hit.collider.gameObject.transform.SendMessage("HitByRaycast", 
					gameObject, SendMessageOptions.DontRequireReceiver);
			
			if(Input.GetMouseButtonDown(0)){
				hit.collider.gameObject.transform.SendMessage("HitByMouse", 
					gameObject, SendMessageOptions.DontRequireReceiver);
			}

			Debug.Log(hit.collider.gameObject.ToString());
			isHit=true;
		}
		else 
			isHit=false;

	}

	void OnGUI()
	{
		if (isHit == false){
			float xMin = (Screen.width / 2) - (crosshairImageNormal.width / 2);
			float yMin = (Screen.height / 2) - (crosshairImageNormal.height / 2);
			GUI.DrawTexture(new Rect(xMin, yMin, crosshairImageNormal.width, 
		                         crosshairImageNormal.height), crosshairImageNormal);
		} else {
			float xMin = (Screen.width / 2) - (crosshairImageOnHit.width / 2);
			float yMin = (Screen.height / 2) - (crosshairImageOnHit.height / 2);
			GUI.DrawTexture(new Rect(xMin, yMin, crosshairImageOnHit.width, 
			                         crosshairImageOnHit.height), crosshairImageOnHit);
		}
	}
}
