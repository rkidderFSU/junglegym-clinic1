using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    Rigidbody rb;
    MeshRenderer mr;
    public int maxHitPoints = 10;
    int currentHitPoints;
    GameObject player;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        mr = gameObject.GetComponent<MeshRenderer>();
        player = GameObject.Find("Player");
        agent = GetComponent<NavMeshAgent>();
        currentHitPoints = maxHitPoints;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;
        if (currentHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHitPoints -= damage;
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        mr.material.color = new Color(1, 0.5f, 0.5f);
        yield return new WaitForSeconds(0.1f);
        mr.material.color = Color.gray;
    }
}
