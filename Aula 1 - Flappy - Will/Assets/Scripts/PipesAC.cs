using System;
using UnityEngine;
using Random = System.Random;

public class PipesAC : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate = 3;
    [SerializeField] private float ElapsedTime = 0f;
    [SerializeField] private float maxY = 1.414f;
    [SerializeField] private float minY = 0.149f;

    void Start()
    {
            Destroy (pipePrefab, 5f);
    }

    
    private void Update()
    {
        ElapsedTime += Time.deltaTime;
        if (ElapsedTime >= spawnRate)
        {
            Instantiate(pipePrefab);
        }
    }
}
