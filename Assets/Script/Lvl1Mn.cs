using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Lvlsd1()
    {
        Debug.Log("Trying to load sd");
        SceneManager.LoadScene("SD 1");
        Debug.Log("SD-1");
    }
}

