using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript3 : MonoBehaviour
{

    public void ButtonStart()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonCredit()
    {
        SceneManager.LoadScene(0);
    }
}
