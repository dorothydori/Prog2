using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
