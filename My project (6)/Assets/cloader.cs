using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cloader : MonoBehaviour
{
    private bool playerDetected;

    [SerializeField]
    private string sceneName;
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDetected = true;
        }
    }

    // Update is called once per frame
     private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDetected = false;
        }
    }
     void Update()
    {
        Debug.Log(playerDetected);
       if(playerDetected && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneName);
        } 
    }
}
