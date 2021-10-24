using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public GameObject maviEkran;
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 movement;
    public Slider healthSlidder;
    public int currentHealth;
    Animator playerAnimator;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        playerAnimator.SetFloat("Horizontal",movement.x);
        playerAnimator.SetFloat("Vertical", movement.y);
        playerAnimator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement*moveSpeed*Time.fixedDeltaTime);
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth = (int)healthSlidder.value;
        currentHealth -= damage;
        healthSlidder.value = currentHealth;
        if (currentHealth<=0)
        {
            GetComponent<PlayerMovement>().enabled = false;
            maviEkran.SetActive(true);
        }

    }
    
}
