using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hata : MonoBehaviour
{
    [Header("Oyun Sesleri")]
    public AudioClip FolderSound;
    public AudioSource SesKaynak;
    bool giris;

    public GameObject HataMesaj;
    public GameObject minecraftScreen;
    void Start()
    {
        SesKaynak.Play();
    }
    private void Update()
    {
        if (giris == true && Input.GetKeyDown(KeyCode.Space))
        {
            HataMesaj.SetActive(false);
            minecraftScreen.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        if (HataMesaj.activeSelf)
        {
            SesKaynak.Play();
        }

       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            giris = true;
        }
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            giris = false;
        }
    }
}
