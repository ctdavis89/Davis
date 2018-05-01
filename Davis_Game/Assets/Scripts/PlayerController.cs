using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpforce;

    private Rigidbody2D myRigidbody;


	// Use this for initialization
	void Start () {

        myRigidbody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
	}
}
