using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private Button restartButton;
    private bool started = false;

    private void Awake()
    {
        Instance = this;
        startScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        
        restartButton.onClick.AddListener(RestartGame);
        Time.timeScale = 0f;
    }

    private void RestartGame()
    {
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && started == false)
        {
            startScreen.SetActive(false);
            started = true;
            Time.timeScale = 1f;
        }
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }
 
}
