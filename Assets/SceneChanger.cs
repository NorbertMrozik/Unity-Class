using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToPlayScene()
    {
        SceneManager.LoadScene("Play");
    }
    public void GoToEndScene()
    {
        SceneManager.LoadScene("End");
    }
    public void GoToMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

}
