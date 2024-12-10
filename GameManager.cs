using UnityEngine;

public class GameManager
{
    public float TimeRemaining { get; private set; } // Tempo restante
    public int TotalCorrectPresents { get; private set; } // Quantidade necessária de presentes corretos
    private int collectedPresents;

    public GameManager(float initialTime, int correctPresents)
    {
        TimeRemaining = initialTime;
        TotalCorrectPresents = correctPresents;
        collectedPresents = 0;
    }

    public void UpdateTime(float deltaTime)
    {
        TimeRemaining -= deltaTime;
    }

    public void AddProgress()
    {
        collectedPresents++;
    }

    public void ReduceTime(float penalty)
    {
        TimeRemaining -= penalty;
    }

    public bool IsGameOver()
    {
        return TimeRemaining <= 0;
    }

    public bool HasWon()
    {
        return collectedPresents >= TotalCorrectPresents;
    }

    public int GetCollectedPresents()
    {
        return collectedPresents;
    }
}
