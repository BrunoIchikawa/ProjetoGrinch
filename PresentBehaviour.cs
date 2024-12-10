using UnityEngine;

public class PresentBehaviour : MonoBehaviour
{
    public bool isCorrect; // Define se o presente é correto ou errado
    private Present present;

    private void Start()
    {
        present = new Present(isCorrect);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManagerBehaviour gameManagerBehaviour = FindObjectOfType<GameManagerBehaviour>();
            if (gameManagerBehaviour != null)
            {
                present.Interact(gameManagerBehaviour.GetGameManager());
            }

            Destroy(gameObject); // Remove o presente após interação
        }
    }
}
