using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gembok_UI : MonoBehaviour
{
    [SerializeField] private int GembokLevel = 2;

    // Level yang sudah diselesaikan
    CompletedLevels completedLevels;

    private void Awake()
    {
        completedLevels = GameObject.Find("CompletedLevel").GetComponent<CompletedLevels>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (completedLevels.CompletedLevel + 1 >= GembokLevel)
        {
            Debug.Log($"Completed levels: {completedLevels.CompletedLevel}");
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
