using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class btn_Plus : MonoBehaviour
{
    public int Angka = 0;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    public void Plus()
    {
        Angka += 1;
        Debug.Log(Angka);
        textMeshPro.text = Angka.ToString();
    }

    public void Minus()
    {

    }

    void Update()
    {
        textMeshPro.text = Angka.ToString();
    }
}


