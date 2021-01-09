using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
   
{
    public AudioSource collectSound;
   void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        SceneManager.LoadScene(19);
    }

}
