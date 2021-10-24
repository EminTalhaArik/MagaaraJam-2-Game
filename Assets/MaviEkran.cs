using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaviEkran : MonoBehaviour
{
    public void BasaDon()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MenuyeDon()
    {
        SceneManager.LoadScene(1);
    }
}
