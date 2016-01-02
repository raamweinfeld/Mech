using UnityEngine;
using System.Collections;

public class LegController : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float legMovement = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * legMovement * 100);
	}
}
