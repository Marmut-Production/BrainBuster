using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Lvlsd1()
    {
        SceneManager.LoadScene("Select Level");
    }
    public void bckmenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void klr()
    {
        Application.Quit();
    }
}

