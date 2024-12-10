public class Present
{
    public bool IsCorrect { get; private set; }

    public Present(bool isCorrect)
    {
        IsCorrect = isCorrect;
    }

    public void Interact(GameManager gameManager)
    {
        if (IsCorrect)
        {
            gameManager.AddProgress();
        }
        else
        {
            gameManager.ReduceTime(5f);
        }
    }
}
