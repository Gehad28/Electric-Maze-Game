using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class End : MonoBehaviour
{
    public GameObject winPanel;
    public AudioSource audioSource;
    public AudioClip winClip;

    public static bool endState = false;

    void Start()
    {
        endState = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Win());
          
        }
    }
    IEnumerator Win()
    {
        winPanel.SetActive(true);
        audioSource.clip = winClip;
        audioSource.Play();
        endState = true;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
        Accident.health = 3;
    }
}
