using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowFruit : MonoBehaviour
{
    [SerializeField] private int FruitIndex = 0;
    [SerializeField] private TextMeshProUGUI textMeshPro;

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = GameObject.Find("CountCollectedFruit").GetComponent<CountCollectedFruit>().FruitCount[FruitIndex].ToString();
    }
}
