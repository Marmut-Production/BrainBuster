using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectFruit : MonoBehaviour
{
     CountCollectedFruit CountCollectedFruit;
    int Index;

    void Start() {
        CountCollectedFruit = GameObject.Find("CountCollectedFruit").GetComponent<CountCollectedFruit>();
    }
    public void SetIndex(int FruitIndex) {
        Index = FruitIndex;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CountCollectedFruit.CollectedFruit(Index);
            Destroy(gameObject);
        }
    }
}
