using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    public void ComecarJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSceneInt(int t)
    {
        SceneManager.LoadScene(t);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
