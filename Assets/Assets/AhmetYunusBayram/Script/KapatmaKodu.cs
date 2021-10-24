using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapatmaKodu : MonoBehaviour
{

    [Header("Oyun Sesleri")]
    public AudioClip FolderSound;
    public AudioSource SesKaynak;



    public GameObject closedFolder;
   




    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player" && Input.GetKeyDown(KeyCode.Space))
        {
            closedFolder.SetActive(false);

            SesKaynak.Play();
            
        }
    }
}
