using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKiller : MonoBehaviour
{
    //we set how the killer can move, here drops from top- down
    
    [SerializeField] float moveSpeed = 3f;

    float startingXPosition;

    public static int Score;
//here we set the killing part
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // Update is called once per frame

    void Start()
    {
    startingXPosition = transform.position.x;
    }

    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        if (transform.position.y <= -9)
        {
            transform.position += Vector3.up * 20f;
            Score++;
        }
    }
}
