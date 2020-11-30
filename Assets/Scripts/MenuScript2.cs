using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript2 : MonoBehaviour
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
