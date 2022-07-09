using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Vector2 jumpVelocity;

    // Update is called once per frame
    void Update()
    {
        // by clicking the bird is jumping 
        if (Input.GetButtonDown("Fire1"))
        {
            // define the velocity of jumping 
            GetComponent<Rigidbody2D>().velocity = jumpVelocity;
        }
    }
}
