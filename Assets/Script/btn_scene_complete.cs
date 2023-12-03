using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class btn_scene_complete : MonoBehaviour
{
    public void lanjut()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Select Level");
    }

    public void menu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
