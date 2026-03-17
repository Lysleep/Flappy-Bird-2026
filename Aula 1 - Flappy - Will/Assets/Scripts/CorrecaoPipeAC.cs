using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrecaoPipeAC : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    
    [SerializeField] private float spawnRate =1 ;
    
    [SerializeField] private float minY = 0.149f;
    [SerializeField] private float maxY = 1.414f;

    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Vector2 spawnPosition = new Vector2(transform.position.x, Random.Range(minY, maxY));
            Instantiate(pipePrefab, spawnPosition, transform.rotation);
        }
    }
}
