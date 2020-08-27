using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour
{
    public string mainMenu;
    public string newGameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AcceptRules()
    {
        SceneManager.LoadScene(newGameScene);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
