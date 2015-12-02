using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

    public GameObject fps;
    bool moveable;
    public float speed = 2.0f;
    Vector3 movement;
	// Use this for initialization
	void Start () {
        movement=new Vector3(0f, 0f, speed* Time.deltaTime);
        fps.SetActive(false);
        moveable = true;
        
	}
	
	// Update is called once per frame
	void Update () {
        GetComponentInChildren<Camera>().transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y + 1.0f, transform.position.z - 0.5f);
        if(moveable)
        {
        transform.Translate(movement);
        }
        else
        {
            movement = (Vector3.Lerp(movement, Vector3.zero, Time.deltaTime*3.0f));
            transform.Translate(movement);
        }
        if(movement == Vector3.zero)
        {
            Debug.Log("Aussteigen:");
            if(Input.GetKeyDown(KeyCode.E))
            {
                fps.SetActive(true);
                GetComponentInChildren<Camera>().enabled = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ABC");
        if(other.tag == "DockCollider")
        {
            moveable = false;
        
        }
    }
}
