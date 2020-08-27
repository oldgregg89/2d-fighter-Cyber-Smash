using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string newGameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() // MenuButton2 - Add to canvas, add name of scene
    {
        SceneManager.LoadScene(newGameScene);
    }
    public void Exit() // MenuButton3
    {
        Application.Quit();
    }
}
// Select buttons - > on click function click + sign, drag canvas into slot

// Create a button in the Hierarchy window
// Navigate to UI and select "Button"
// This creates a canvas
// Select Canvas, Add Component(script)
// In the provided text boxes type the name of the scene
// For example "Main Menu" enter MainMenu or the scene name
// Select Button, in the "On Click ()" section, drag canvas to the 
// Slot under "Runtime Only" then on the right side
// Navigate to the correct function (eg: Rules.AcceptRules)