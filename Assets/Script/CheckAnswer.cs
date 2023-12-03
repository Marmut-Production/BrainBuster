using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckAnswer : MonoBehaviour
{
    [SerializeField] private int CorrectAnswer = 3;
    [SerializeField] private string ChangeLevel = "";
    public void CheckUserAnswer() {
        int userAnswer = GameObject.Find("Level Manager").GetComponent<CounterManager>().Angka;
        if (userAnswer == CorrectAnswer) {
            SceneManager.LoadScene(ChangeLevel);
        } else {
            Debug.Log("Wrong!");
        }
    }
}
