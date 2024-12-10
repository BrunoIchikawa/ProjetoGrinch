using UnityEngine;
public class MenuManager
{
     public string gameScene;
     public string creditsScene;
     public string menuScene;

    public void StartGame()
    {
        gameScene = "GameScene";
        UnityEngine.SceneManagement.SceneManager.LoadScene(gameScene);
    }

    public void Credits()
    {
        creditsScene = "CreditsScene";
        UnityEngine.SceneManagement.SceneManager.LoadScene(creditsScene);
    }

    public void Menu()
    {
        menuScene = "MenuScene";
        UnityEngine.SceneManagement.SceneManager.LoadScene(menuScene);
    }

    public void QuitGame()
    {
        UnityEngine.Application.Quit();
    }
}
