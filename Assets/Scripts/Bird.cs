using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //we define a new variable to control the amount of force.
    [SerializeField] float _launchForce = 500;
    [SerializeField] float _maxDragDistance = 5;
    
    Vector2 _startPosition;
    Rigidbody2D _rigidbody2D;
    SpriteRenderer _spriteRenderer;

    // void means no return type.
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _startPosition = _rigidbody2D.position;
        _rigidbody2D.isKinematic = true;
    }
    //we define this to control the mouse function for playing.
    void OnMouseDown()
    {
        //by clicking the bird its color changes to red
        _spriteRenderer.color = Color.red;
    }

    //define a function to return the bird's color by releasing the mouse to the white.
    void OnMouseUp()
    {
        //Get the current position
        Vector2 currentPosition = _rigidbody2D.position;
        //Get the direction by subtracting the start position by the current position. Here Vector2 has just X and Y components.
        Vector2 direction = _startPosition - currentPosition;
        direction.Normalize();
        
        _rigidbody2D.isKinematic = false;
        _rigidbody2D.AddForce(direction * _launchForce);
        
        _spriteRenderer.color = Color.white;
    }

    //to move the bird.
    void OnMouseDrag()
    {
        //define the camera position. This actually gives us the mouse position in the world space in our game.

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 desiredPosition = mousePosition;

        float distance = Vector2.Distance(desiredPosition, _startPosition);
        //define a desired position
        if (distance > _maxDragDistance)
        {
            Vector2 direction = desiredPosition - _startPosition;
            direction.Normalize();
            desiredPosition = _startPosition + (direction * _maxDragDistance);
        }
        
        if (desiredPosition.x > _startPosition.x)
            desiredPosition.x = _startPosition.x;

        _rigidbody2D.position = desiredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(ResetAfterDelay());
    }

    IEnumerator ResetAfterDelay()
    {
        //define a reset time. After 3 second the next line of the code is operating. 
        yield return new WaitForSeconds(3);
        _rigidbody2D.position = _startPosition;
        _rigidbody2D.isKinematic = true;
        _rigidbody2D.velocity = Vector2.zero;
    }
}
