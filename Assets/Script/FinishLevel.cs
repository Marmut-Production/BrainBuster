using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public TextMeshProUGUI levelCompleteText;
    public Image LevelCompleteImage; 

    // Index buah
    int BananaIndex = 0;
    int AppleIndex = 1;
    int PearIndex = 2;

    // Buah yang harus dikumpulkan
    [SerializeField] private int AppleCount = 0;
    [SerializeField] private int BananaCount = 0;
    [SerializeField] private int PearCount = 0;

    [SerializeField] private int NextLevelName;

    // Buah yang sudah dikumpulkan
    // Collected CollectedFruit = ;
    int CollectedApple;
    int CollectedBanana;
    int CollectedPear;

    // Start is called before the first frame update
    void Start()
    {
         levelCompleteText.gameObject.SetActive(false);
         LevelCompleteImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Menghitung jumlah buah yang dikumpulkan
        CountCollectedFruit();
        if ((CollectedApple == AppleCount) && (CollectedBanana == BananaCount) && (CollectedPear == PearCount))
        {
            levelCompleteText.gameObject.SetActive(true);
            SceneManager.LoadScene(NextLevelName);
        } 
        else if ((CollectedApple > AppleCount) || (CollectedBanana > BananaCount) || (CollectedPear > PearCount))
        {
            Debug.Log("Jumlah buah yang dikumpulkan melebihi jumlah buah yang harus dikumpulkan");
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
