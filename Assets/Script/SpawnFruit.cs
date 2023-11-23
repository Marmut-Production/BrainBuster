using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class SpawnFruit : MonoBehaviour
{
    Camera mainCamera;
    GameObject fruit;

    [SerializeField] public GameObject[] FruitsArray;
    public float SpawnDelay = 0f;
    public bool isSpawning = false;
    public float verticalVelocity = -5f; // kecepatan jatuh buah

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start method called");
        mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("Main Camera tidak ditemukan");
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (!isSpawning)
        {
            isSpawning = true;
            StartCoroutine(SpawnFruitCoroutine());
        }

        // Get the main camera's orthographic size
        float cameraHeight = Camera.main.orthographicSize;

        // Iterate over each child of the current GameObject
        foreach (Transform child in transform)
        {
            // Check if the child's y-coordinate is less than the negative of the camera's orthographic size
            if (child.position.y <= -cameraHeight)
            {
                // If it is, despawn the child
                LeanPool.Despawn(child.gameObject);
                Debug.Log("Fruit destroyed");
            }
        }
    }

    Vector3 GenerateRandomCoordinates()
    {
        float cameraWidth = mainCamera.orthographicSize * 2 * mainCamera.aspect;

        float randomX = Random.Range(-cameraWidth / 2 + 1, cameraWidth / 2 - 1);
        float randomY = mainCamera.orthographicSize + 3f;

        Vector3 randomCoordinates = new Vector3(randomX, randomY, 0f);

        return randomCoordinates;
    }

    int GenerateRandomFruitIndex()
    {
        int randomIndex = Random.Range(0, FruitsArray.Length);
        return randomIndex;
    }

    IEnumerator SpawnFruitCoroutine()
    {
        yield return new WaitForSeconds(SpawnDelay);
        Vector3 randomCoordinates = GenerateRandomCoordinates();
        int randomFruitIndex = GenerateRandomFruitIndex();

        fruit = LeanPool.Spawn(FruitsArray[randomFruitIndex], randomCoordinates, Quaternion.identity);
        fruit.transform.SetParent(transform);
        Rigidbody2D rb = fruit.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector2(0, verticalVelocity);
        }

        //Memasukan FruitIndex ke Script CollectFruit
        CollectFruit CollectFruit = fruit.GetComponent<CollectFruit>();
        if (CollectFruit != null)
        {
            CollectFruit.SetIndex(randomFruitIndex);
        }

        isSpawning = false;
    }
}
