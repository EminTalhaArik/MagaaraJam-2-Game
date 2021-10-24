using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasarVer : MonoBehaviour
{
    GameObject player;
    public float vurusSuresi;
    public int damage;
    bool giris = false;
    float timeOut;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (giris ==true)
        {
            timeOut += Time.deltaTime;
            if (timeOut >= vurusSuresi)
            {
                timeOut = 0;
                player.GetComponent<PlayerMovement>().TakeDamage(damage);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            giris = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            giris = false;
            timeOut = 0;
        }
    }
}
