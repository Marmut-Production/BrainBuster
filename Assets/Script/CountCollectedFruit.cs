using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCollectedFruit : MonoBehaviour
{
    SpawnFruit spawnFruit;
    public int[] FruitCount = new int[3];
    // Start is called before the first frame update
    public void CollectedFruit(int FruitIndex) {
        FruitCount[FruitIndex] += 1;
        Debug.Log($"{FruitIndex} count: {FruitCount[FruitIndex]}");
    }
}
