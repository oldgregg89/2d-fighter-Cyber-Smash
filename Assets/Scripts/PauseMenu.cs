using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public string exitGame;
    public string restartGame;
    public GameObject theMenu;
    // Start is called before the first frame update
    void Start()
    {
       theMenu.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(theMenu.activeInHierarchy)
            {
                theMenu.SetActive(false);
                Time.timeScale = 1;

            }
            else
            {
                theMenu.SetActive(true);
                Time.timeScale = 0;

            }
        }
    }
    public void ResumeGame()
    {
        theMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(exitGame);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(restartGame);
    }
}
