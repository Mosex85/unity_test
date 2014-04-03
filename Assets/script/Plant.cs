using UnityEngine;
using System.Collections;

public class Plant : MonoBehaviour {

	Water water;
	TempControl tempControl;

	void Awake()
	{
		water = (Water)GetComponent<Water>();
		tempControl = (TempControl)GetComponent<TempControl>();
	}

	void Start () 
	{
		Debug.Log("NPK: " + water.N + "-" + water.P + "-" + water.K);
		Debug.Log("PH :" + water.PH_Value);
		Debug.Log("Temp :" + tempControl.temperature);
	}
	

	void Update () 
	{
	
	}
}
