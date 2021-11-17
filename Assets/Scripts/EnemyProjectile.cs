using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject enemyProjectile;
    Vector3 respawn = new Vector3(5, -5,0);
    int rand = 0;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(-6, 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(rand * Time.deltaTime, -6 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = respawn;
            Destroy(enemyProjectile);
            if (GameManager.lives > 0) {
                GameManager.lives--;
            } 
        }

        if (collision.gameObject.tag == "Finish")
        {
            Destroy(enemyProjectile);
        }
    }
}
