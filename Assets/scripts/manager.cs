using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public GameObject resumeButton;
    public GameObject main_menuButton;
    public GameObject exitButton;
    public GameObject exitConfirmation;
    public GameObject pausePannel;
    public GameObject gamePannel;
    public GameObject controllPannel;
    public GameObject controllButton;


    public void pauseButton()
    {
        pausePannel.SetActive(true);
        gamePannel.SetActive(false);
        Time.timeScale = 0f;

    }

    public void mainMenu()
    {
        Debug.Log("main menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void resume()
    {
        pausePannel.SetActive(false);
        gamePannel.SetActive(true);
        Time.timeScale = 1f;
    }

    public void quitMenu()
    {
        exitConfirmation.SetActive(true);
    }

    public void exitCancel()
    {
        exitConfirmation.SetActive(false);
    }
    public void quitt()
    {
        Application.Quit();
    }

    public void rarrow()
    {
        if (resumeButton.activeSelf)
        {
            resumeButton.SetActive(false);
            main_menuButton.SetActive(true);
            controllButton.SetActive(false);
            exitButton.SetActive(false);
        }

        else if (main_menuButton.activeSelf)
        {
            resumeButton.SetActive(false);
            main_menuButton.SetActive(false);
            controllButton.SetActive(true);
            exitButton.SetActive(false);
        }
        else if (controllButton.activeSelf)
        {
            resumeButton.SetActive(false);
            main_menuButton.SetActive(false);
            controllButton.SetActive(false);
            exitButton.SetActive(true);
        }
        else if (exitButton.activeSelf)
        {
            resumeButton.SetActive(true);
            main_menuButton.SetActive(false);
            controllButton.SetActive(false);
            exitButton.SetActive(false);
        }
    
    }

    public void larrow()
    {
        if (resumeButton.activeSelf)
        {
            resumeButton.SetActive(false);
            main_menuButton.SetActive(false);
            controllButton.SetActive(false);
            exitButton.SetActive(true);

        }

        else if (main_menuButton.activeSelf)
        {

            resumeButton.SetActive(true);
            main_menuButton.SetActive(false);
            controllButton.SetActive(false);
            exitButton.SetActive(false);

        }

        else if (exitButton.activeSelf)
        {
  
            resumeButton.SetActive(false);
            main_menuButton.SetActive(false);
            controllButton.SetActive(true);
            exitButton.SetActive(false);

        }
        else if (controllButton.activeSelf)
        {

            resumeButton.SetActive(false);
            main_menuButton.SetActive(true);
            controllButton.SetActive(false);
            exitButton.SetActive(false);

        }

    }
    public void controlls()
    {
        controllPannel.SetActive(true);
    }
     
    public void controllCancel()
    {
        controllPannel.SetActive(false);
    }

    public void replay()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}


