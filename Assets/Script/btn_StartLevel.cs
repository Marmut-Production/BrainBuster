using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SceneManagement;
using static CompletedLevels;

public class btn_StartLevel : MonoBehaviour
{
    CompletedLevels completedLevels;
    int finishedLevel;
    GameObject btnClickedLevel;
    string ClickedLevelName;
    int ClickedLevel;

    private void Awake()
    {
        ClickedLevelName = Regex.Replace(gameObject.name, "[^0-9]", "");
        ClickedLevel = int.Parse(ClickedLevelName);
        Debug.Log(ClickedLevel);
        completedLevels = GameObject.Find("CompletedLevel").GetComponent<CompletedLevels>();
        finishedLevel = completedLevels.CompletedLevel;

        btnClickedLevel = transform.parent.gameObject;
    }

    public void StartLevel(string levelName)
    {
        if (finishedLevel == ClickedLevel - 1) {
            SceneManager.LoadScene(levelName);
        } else {
            Debug.Log("Level masih terkunci!");
        }
    }
}
