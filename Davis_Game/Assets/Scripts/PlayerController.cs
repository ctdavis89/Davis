using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpforce;

    private Rigidbody2D myRigidbody;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

    RaycastHit _hit;
    ContactFilter2D _filter;

	// Use this for initialization
	void Start () {

        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);


        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpforce);
            }
            else
            {
                Grapple();
            }
        }
	}

    void Grapple()
    {

        if(Physics2D.Raycast(transform.position, transform.up, 1000 _filter ,_hits))
        {
            


        }
        if (Physics.Raycast(transform.position, transform.up, out _hit, 1000))
        {

            
        }


    }

}
