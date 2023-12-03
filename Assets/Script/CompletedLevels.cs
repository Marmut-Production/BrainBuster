using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedLevels : MonoBehaviour
{
    public int CompletedLevel = 0;

    // save completed level
    public void SaveCompletedLevel()
    {
        ES3.Save("CompletedLevel", CompletedLevel);
    }

    public void ResetCompletedLevel()
    {
        if (ES3.KeyExists("CompletedLevel"))
        {
            ES3.DeleteKey("CompletedLevel");
            CompletedLevel = 0;
        }
    }

    // load completed level
    void Start()
    {
        if (ES3.KeyExists("CompletedLevel"))
        {
            CompletedLevel = ES3.Load<int>("CompletedLevel");
            Debug.Log($"Completed levels: {CompletedLevel}");
        }
    }
}
