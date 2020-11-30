using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript4 : MonoBehaviour
{

    public void ButtonStart()
    {
        SceneManager.LoadScene(5);
    }

    public void ButtonCredit()
    {
        SceneManager.LoadScene(0);
    }
}
