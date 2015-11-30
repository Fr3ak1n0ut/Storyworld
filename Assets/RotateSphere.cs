using UnityEngine;
using System.Collections;

public class RotateSphere : MonoBehaviour {
    public float rotationSpeed = 0.1f;
    public float rotationBounce = 10.0f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up + new Vector3(0, 1, -1) * Mathf.Sin(Time.deltaTime * rotationBounce), rotationSpeed);
	}
}
