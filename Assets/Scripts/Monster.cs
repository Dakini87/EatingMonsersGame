using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Monster : MonoBehaviour
{
    // this is going to allow us to assign the sprite to the monster in the inspector.
    [SerializeField] Sprite _deadSprite;
    // assign a particle system 
    [SerializeField] ParticleSystem _particleSystem;
    
    bool _hasDied;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // if monster die by collision, we define what will happen.
        if (ShouldDieFromCollision(collision))
        {
            StartCoroutine(Die());
        }
    }

    bool ShouldDieFromCollision(Collision2D collision)
    {
        // if the monster had died it should not die from another collision, to prevent multiple deaths.
        if (_hasDied)
            return false;
        
        Bird bird = collision.gameObject.GetComponent<Bird>();
        // if bird is not equal to null (if there is a bird in that collision), the value true will be returned. 
        if (bird != null)
            return true;

        // define the vector or the direction for hitting the enemies. 
        if (collision.contacts[0].normal.y < -0.5)
            return true;
            
        return false;
    }

    IEnumerator Die()
    {
        _hasDied = true;
        GetComponent<SpriteRenderer>().sprite = _deadSprite;
        _particleSystem.Play();
        yield return new WaitForSeconds(1);

        gameObject.SetActive(false);
    }
}
    