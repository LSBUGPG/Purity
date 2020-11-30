using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript1 : MonoBehaviour
{

    public void ButtonStart()
    {
        SceneManager.LoadScene(3);
    }

    public void ButtonCredit()
    {
        SceneManager.LoadScene(0);
    }
}
