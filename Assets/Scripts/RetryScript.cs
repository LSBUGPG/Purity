using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour
{

    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonCredit()
    {
        SceneManager.LoadScene(0);
    }
}
