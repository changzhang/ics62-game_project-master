using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Input.GetAxis ("Horizontal") * speed * Time.deltaTime);
		transform.Translate (Vector3.forward * Input.GetAxis ("Vertical") * speed * Time.deltaTime);
	
	}
}
