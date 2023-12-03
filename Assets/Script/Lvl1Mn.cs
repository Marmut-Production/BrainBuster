using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void sd()
    {
        SceneManager.LoadScene("Select Level");
    }
    public void smp()
    {
        SceneManager.LoadScene("Buy DLC");
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

