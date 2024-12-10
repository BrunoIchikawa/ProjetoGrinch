using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerBehaviour : MonoBehaviour
{
    private MenuManager menuManager;

    private void Start()
    {
        menuManager = new MenuManager();
    }

    public void StartGame()
    {
        menuManager.StartGame();
    }

    public void Credits()
    {
        menuManager.Credits();
    }

    public void Menu()
    {
        menuManager.Menu();
    }

    public void QuitGame()
    {
        menuManager.QuitGame();
    }
}

