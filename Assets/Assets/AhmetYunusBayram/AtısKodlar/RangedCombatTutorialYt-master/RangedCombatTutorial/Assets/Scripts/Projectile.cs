using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile() {
        GameObject deneme=  Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(deneme,0.5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "EnemyBody")
        {
            collision.gameObject.transform.parent.GetComponent<Enemy>().TakeDamage(damage);

        }
        if (collision.gameObject.layer ==6)
        {
            DestroyProjectile();
        }

    }
}
