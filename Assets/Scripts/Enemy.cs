using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.07f;
    float speed = 0.07f;
    int numOfMovements = 0;    
    int maxNumOfMovements = 25;

    public GameObject enemy;
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numOfMovements == maxNumOfMovements)
        {
            transform.Translate(new Vector3(0, speed, 0));
            numOfMovements = -1;
            speed = -speed;
            timer = 0;
        }

        timer += Time.deltaTime;

        if (timer > timeToMove && numOfMovements < maxNumOfMovements)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numOfMovements++;
        }

        enemyShoot();
    }

    void enemyShoot()
    {
        if (Random.Range(0f, 600f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.6f, 0), transform.rotation) as GameObject;
        }
    }
}
