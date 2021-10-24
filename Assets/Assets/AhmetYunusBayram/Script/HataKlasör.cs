using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HataKlasör : MonoBehaviour
{
    [Header("Oyun Sesleri")]
    public AudioClip FolderSound;
    public AudioSource SesKaynak;



    public GameObject ErorFolder;
    public GameObject closedFolder;
    public Vector3 spawnTransform;




    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player" && Input.GetKeyDown(KeyCode.Space))
        {
            closedFolder.SetActive(false);

            ErorFolder.SetActive(true);
            SesKaynak.Play();
            GameObject.FindGameObjectWithTag("player").transform.position = spawnTransform;
        }
    }
}
