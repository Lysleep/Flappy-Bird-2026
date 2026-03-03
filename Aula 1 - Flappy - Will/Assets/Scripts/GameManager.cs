using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    private bool started = false;

    private void Awake()
    {
        StartScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && started == false)
        {
            StartScreen.SetActive(false);
            started = true;
            Time.timeScale = 1f;
        }
    }
 
}
