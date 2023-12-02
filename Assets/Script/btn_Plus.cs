using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class btn_Plus : MonoBehaviour
{
    public CounterManager counterManager;
    
    [SerializeField] TextMeshProUGUI textMeshPro;

    public void Plus()
    {
        counterManager.Angka += 1;
        Debug.Log(counterManager.Angka);
        textMeshPro.text = counterManager.Angka.ToString();
    }

    public void Minus()
    {
        if (counterManager.Angka > 0)
        {
            counterManager.Angka -= 1;
        }
        Debug.Log(counterManager.Angka);
        textMeshPro.text = counterManager.Angka.ToString();
    }
}


