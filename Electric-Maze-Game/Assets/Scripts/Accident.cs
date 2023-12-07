using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Accident : MonoBehaviour
{
    public GameObject losePanel;
    public GameObject redPanel;
    public float redON = 0.3f;
    public static int health = 3;
    public AudioSource  Audio;
    public AudioClip loseClip;
    public AudioClip hitClip;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="Maze")
        {
            StartCoroutine(red());
            Audio.clip = hitClip;
            Audio.Play();
            health--;
            if (health <= 0)
            {
                StartCoroutine(lose());
            }
        }

       
    }

    IEnumerator red()
    {
        redPanel.SetActive(true);
        yield return new WaitForSeconds(redON);
        redPanel.SetActive(false);
    }

    IEnumerator lose()
    {
        losePanel.SetActive(true);
        Audio.clip = loseClip;
        Audio.Play();
        yield return new WaitForSeconds(3);
        Destroy(gameObject,2); 
        SceneManager.LoadScene(0);
        health = 3;
    }
   
}
