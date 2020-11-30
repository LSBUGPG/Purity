using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript4 : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene(4);
    }

    public void ButtonCredit()
    {
        SceneManager.LoadScene(0);
    }
 
}
