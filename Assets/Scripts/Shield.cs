using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

     void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        theScore += 1;
        scoreText.GetComponent<Text>().text = "Fathers Shield 1/ " + theScore;
        Destroy(gameObject);
    }
}
