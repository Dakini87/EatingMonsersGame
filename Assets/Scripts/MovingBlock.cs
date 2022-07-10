using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;

    float startingYPosition;
    public static int Score;
    //public static int HighScore;

    void Start()
    {
        // save Y position
        startingYPosition = transform.position.y;
        // when we reload our level the score would be 0.
        Score = 0;
    }

    void Update()
    {
        // every single unit go just one unit to the left and we define that this movement happens in a defined unit.
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;

        // prevent to falling the crate and define a new position 30m to the right. Read the X value of the position and if it is less that -15, reset the position. 
        if (transform.position.x <= -15)
        {
            transform.position += Vector3.right * 30f;
            // by this code the crate will be created randomly 
            float newY = startingYPosition + UnityEngine.Random.Range(-1f, 1f);
            transform.position = new Vector3(transform.position.x, newY, 0f);
            // increment it by one.
            Score++;

            if (Score >= 50)
            {
                SceneManager.LoadScene("Level1");
            }
        }
    }
}
