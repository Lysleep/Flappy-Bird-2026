using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    //[SerializeField] private TextMeshProUGUI score;
    //[SerializeField] private int scorepoints = 0;
    
    //private Collider2D scoreTrigger;

    private void Start()
    {
        Destroy (gameObject, 3f);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < -0.405)
        {
            AudioManager.Instance.PlayScore();
            //score.text = "Score: " + scorepoints;
        }
    }
    
    //OnTriggerEnter2D
}
