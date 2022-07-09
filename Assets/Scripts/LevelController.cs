using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    // collection of monsters.
    Monster[] _monsters;

    // we need to track all the monsters, how many of them were dead and so on. 
    void OnEnable()
    {
        // collect the monsters.
        _monsters = FindObjectsOfType<Monster>();
    }
    // Update is called once per frame
    void Update()
    {
        // if all monsters are dead go to the next level. 
        if (MonstersAreAllDead())
            GoToNextLevel();
    }
    void GoToNextLevel()
    {
        Debug.Log("Go to level " + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }
    bool MonstersAreAllDead()
    {
        // we are going to go every monster
        foreach (var monster in _monsters)
        {
            if (monster.gameObject.activeSelf)
                return false;
        }
        return true;
    }
}
