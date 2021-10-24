using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Ayarlar;
    public GameObject EmeðiGecen;
    public AudioSource theme;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Basla()
    {
        SceneManager.LoadScene("Hikaye");
    }
    public void MenuGel()
    {
        SceneManager.LoadScene("menu");
    }

    public void AyarlarGit()
    {
        Menu.SetActive(false);
        EmeðiGecen.SetActive(false);
        Ayarlar.SetActive(true);
    }
    public void Emek()
    {
        Menu.SetActive(false);
        
        EmeðiGecen.SetActive(true);
    }
    public void Çýkýs()
    {
        Application.Quit();
    }

    public void MenuGeri()
    {
        EmeðiGecen.SetActive(false);
        Ayarlar.SetActive(false);
        Menu.SetActive(true);
    }

    public void SetQualitu(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }
    public void SetMusiz(bool isMusic)
    {
        theme.mute  = !isMusic;
    }
}
