using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillOnTouch : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D collision)
     // we will define what happens if we touch this block:
     {
          if (collision.collider.CompareTag("Player"))
          {
               SceneManager.LoadScene(SceneManager.GetActiveScene().name);
               
          }
     }
}
