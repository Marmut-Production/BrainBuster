using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SceneManagement;
using static CompletedLevels;

public class btn_StartLevel : MonoBehaviour
{
    CompletedLevels completedLevels;
    GameObject btnClickedLevel;
    string ClickedLevelName;
    int ClickedLevel;

    private void Awake()
    {
        ClickedLevelName = Regex.Replace(gameObject.name, "[^0-9]", "");
        ClickedLevel = int.Parse(ClickedLevelName);
        completedLevels = GameObject.Find("CompletedLevel").GetComponent<CompletedLevels>();

        btnClickedLevel = transform.parent.gameObject;

        Debug.Log($"Button read completed level: {completedLevels.CompletedLevel}");
    }

    public void StartLevel(string levelName)
    {
        if (completedLevels.CompletedLevel >= ClickedLevel - 1) {
            SceneManager.LoadScene(levelName);
        } else {
            Debug.Log("Level masih terkunci!");
        }
    }
}
