using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountdown3 : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 650;
    public bool takingAway = false;
    public string gameoverLevel;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = secondsLeft / 70 + " : " + secondsLeft % 70;
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft == 0)
        {
            SceneManager.LoadScene(gameoverLevel);
        }
        textDisplay.GetComponent<Text>().text = secondsLeft / 70 + " : " + secondsLeft % 70;
        takingAway = false;
    }
}
