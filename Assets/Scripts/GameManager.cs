using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public Text info;
    public Text endScreen;

    // Start is called before the first frame update
    void Start()
    {
        info.text = "Lives: " + lives;
        endScreen.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        info.text = "Lives: " + lives;
        if (lives == 0)
        {
            endScreen.text = "YOU LOSE!";
        }
        else if(GameObject.FindGameObjectsWithTag("enemy").Length == 0) {
            endScreen.text = "YOU WIN!";
        }
    }
}
