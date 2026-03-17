using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    [SerializeField] private GameObject GOScreen;
    private bool started = false;

    private void Awake()
    {
        StartScreen.SetActive(true);
        GOScreen.SetActive(false);
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

    public void gameOver()
    {
        GOScreen.SetActive(true);
    }
 
}
