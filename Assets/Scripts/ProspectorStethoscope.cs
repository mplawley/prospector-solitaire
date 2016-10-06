using UnityEngine;
using System.Collections;

public class ProspectorStethoscope : MonoBehaviour
{
	public Vector3 mousePosition;
	// Use this for initialization
	void Start()
	{
	
	}
	
	// Update is called once per frame
	void Update()
	{
		mousePosition = Input.mousePosition;
	}
}
