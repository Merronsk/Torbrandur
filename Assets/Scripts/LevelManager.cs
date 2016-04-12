using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Transform Player;
    public Transform mainMenu, optionsMenu, exitMenu;
    public void LoadScene(string name)
    {
        SceneManager.LoadScene("Scene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OptionsMenu(bool clicked)
    {
        if (clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);

        }
    }
    public void ExitMenu(bool clicked)
    {
        if (clicked == true)
        {
            exitMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            exitMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }


}
   








