using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControllerNoLight : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("MainSceneWeakLight");
    }
}
