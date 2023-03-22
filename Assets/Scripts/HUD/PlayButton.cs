using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour
{
    public void Load(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void Load(string s)
    {
        SceneManager.LoadScene(s);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
