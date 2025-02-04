using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Rigidbody rb;
    MeshRenderer mr;
    public int maxHitPoints = 10;
    int currentHitPoints;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = gameObject.GetComponent<MeshRenderer>();
        currentHitPoints = maxHitPoints;
        StartCoroutine(WaitAndDamage());
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHitPoints -= damage;
        StartCoroutine(ChangeColor());
        Debug.Log("Current Hit Points = " + currentHitPoints);
    }

    IEnumerator WaitAndDamage() // test for taking damage. will remove later
    {
        yield return new WaitForSeconds(0.5f);
        TakeDamage(1);
        StartCoroutine(WaitAndDamage());
    }

    IEnumerator ChangeColor()
    {
        mr.material.color = new Color(1, 0.5f, 0.5f);
        yield return new WaitForSeconds(0.1f);
        mr.material.color = Color.white;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody collisionRb = collision.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(10, 0, 10, ForceMode.Impulse);
            collisionRb.AddForce(-10, 0, -10, ForceMode.Impulse);
        }
    }
}
