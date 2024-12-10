using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerBehaviour : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField] public TextMeshProUGUI timeText;
    [SerializeField] public TextMeshProUGUI progressText;

    void Start()
    {
        gameManager = new GameManager(60f, 5); // Inicializa com tempo e quantidade de presentes
        UpdateUI();
    }

    void Update()
    {
        gameManager.UpdateTime(Time.deltaTime);

        if (gameManager.IsGameOver())
        {
            SceneManager.LoadScene("GameOverScene");
        }
        else if (gameManager.HasWon())
        {
            SceneManager.LoadScene("WinScene");
        }

        UpdateUI();
    }

    public void AddProgress()
    {
        gameManager.AddProgress();
        UpdateUI();
    }

    public void ReduceTime()
    {
        gameManager.ReduceTime(5f);
        UpdateUI();
    }

    void UpdateUI()
    {
        timeText.text = $"Tempo Restante: {Mathf.CeilToInt(gameManager.TimeRemaining)}";
        progressText.text = $"Progresso: {gameManager.GetCollectedPresents()}/{gameManager.TotalCorrectPresents}";
    }

    // Método para retornar a instância de GameManager
    public GameManager GetGameManager()
    {
        return gameManager;
    }
}
