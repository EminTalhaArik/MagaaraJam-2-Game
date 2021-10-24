using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed =5f;
    public float VururkenMesafe;
    float currentHealth;
    bool giris=false;
    int run;
    float sagSol;
    float maxHealth = 100;
    public Slider healthBar;
    Vector2 direction;
    //private float timeOut;

    //public Transform firePoint;
    //public GameObject bulletPrefab;
    //public float bulletForce = 20f;
    void Start()
    {
        player = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.value = currentHealth;
    }

    void Update()
    {
        direction = player.position - transform.position;
        //float angle = Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;
        /*
        timeOut += Time.deltaTime;
        if (timeOut>0.3)
        {
            //Shooting();
            timeOut = 0;
        }*/
    }
    private void FixedUpdate()
    {
        if (giris=true && Vector2.Distance(transform.position, player.transform.position) > VururkenMesafe)
        {
            MoveCharacter(direction);
        }
    }
    void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        run = 1;
        gameObject.GetComponent<Animator>().SetInteger("Run", run);
        if (transform.position.x > player.transform.position.x)
        {
            sagSol = -1.0f;
            gameObject.GetComponent<Animator>().SetFloat("SagSol", sagSol);
        }
        else
        {
            sagSol = 1.0f;
            gameObject.GetComponent<Animator>().SetFloat("SagSol", sagSol);
        }
    }
    /*
    void Shooting()
    {
        GameObject bullet =  Instantiate(bulletPrefab, firePoint.position,transform.rotation);
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(firePoint.up*bulletForce,ForceMode2D.Impulse);
    }*/
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == player.gameObject)
        {
            giris = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            giris = false;
            Debug.Log("ıdle");
            run = 0;
            gameObject.GetComponent<Animator>().SetInteger("Run",run);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.value = currentHealth;
        if (currentHealth<=0)
        {
            gameObject.layer = 0;
            Destroy(gameObject, 1f);

            gameObject.GetComponent<Animator>().SetBool("Death", true);
            gameObject.GetComponent<Enemy>().enabled = false;
        }
    }
}
