using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject projectile;
    public GameObject projectileClone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.lives > 0) {
            playerMove();
            playerShoot();
        }
    }

    void playerMove() {
        if (Input.GetKey("w"))
        {
            if (player.transform.position.y < 4.5)
            {
                transform.Translate(new Vector3(0, -6 * Time.deltaTime, 0));
            };
        }
        if (Input.GetKey("s"))
        {
            if (player.transform.position.y > -4.5)
            {
                transform.Translate(new Vector3(0, 6 * Time.deltaTime, 0));
            }
        }
        if (Input.GetKey("a"))
        {
            if (player.transform.position.x > -5)
            {
                transform.Translate(new Vector3(6 * Time.deltaTime, 0, 0));
            }
        }
        if (Input.GetKey("d"))
        {
            if (player.transform.position.x < 5)
            {
                transform.Translate(new Vector3(-6 * Time.deltaTime, 0, 0));
            }
        }
    }

    void playerShoot() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            projectileClone = Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y + 0.6f,0), transform.rotation) as GameObject;
        }
    }
}
