﻿using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce;
    private bool onPlatform;

    private Rigidbody2D theRigidbody;
    private Collider2D theCollider;
    public LayerMask layerMaskPlatform;
    public Renderer theRenderer;
    public DeathMenu theDeathMenuScript;

    void Start ()
    {
        theRigidbody = GetComponent<Rigidbody2D>();
        theCollider = GetComponent<Collider2D>();
        theRenderer = GetComponent<Renderer>();
        Time.timeScale = 0f;
    }
	
	void Update ()
    {
        onPlatform = Physics2D.IsTouchingLayers(theCollider, layerMaskPlatform);
        theRigidbody.velocity = new Vector2(movementSpeed, theRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            theRigidbody.velocity = new Vector2(theRigidbody.velocity.x, jumpForce);
            Time.timeScale = 1f;
        }

        if (onPlatform)
        {
            theDeathMenuScript.OnDeath();
        }
	}
}
