using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject OptionsMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenOptionsMenu()
    {
        OptionsMenu.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Guit Game!");
        Application.Quit();
    }
}
