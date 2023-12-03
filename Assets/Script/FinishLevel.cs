using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{

    // Index buah
    int BananaIndex = 0;
    int AppleIndex = 1;
    int PearIndex = 2;

    // Buah yang harus dikumpulkan
    [SerializeField] private int AppleCount = 0;
    [SerializeField] private int BananaCount = 0;
    [SerializeField] private int PearCount = 0;

    // Level yang sudah diselesaikan
    CompletedLevels completedLevels;

    // Buah yang sudah dikumpulkan
    // Collected CollectedFruit = ;
    int CollectedApple;
    int CollectedBanana;
    int CollectedPear;

    private void Awake()
    {
        completedLevels = GameObject.Find("CompletedLevel").GetComponent<CompletedLevels>();
    }

    // Update is called once per frame
    void Update()
    {
        // Menghitung jumlah buah yang dikumpulkan
        CountCollectedFruit();
        if ((CollectedApple == AppleCount) && (CollectedBanana == BananaCount) && (CollectedPear == PearCount))
        {
            completedLevels.CompletedLevel += 1;
            SceneManager.LoadScene("complete");
        }
        else if ((CollectedApple > AppleCount) || (CollectedBanana > BananaCount) || (CollectedPear > PearCount))
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    // Menghitung jumlah buah yang dikumpulkan
    void CountCollectedFruit()
    {
        CollectedApple = GameObject.Find("CountCollectedFruit").GetComponent<CountCollectedFruit>().FruitCount[AppleIndex];
        CollectedBanana = GameObject.Find("CountCollectedFruit").GetComponent<CountCollectedFruit>().FruitCount[BananaIndex];
        CollectedPear = GameObject.Find("CountCollectedFruit").GetComponent<CountCollectedFruit>().FruitCount[PearIndex];
    }
}
