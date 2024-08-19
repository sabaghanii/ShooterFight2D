using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public gameManager gm;
    //public Text scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
            //load game over or restart
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.CompareTag("pickup"))
        {
            //Debug.Log("picked the coin");
            //increment score
            gm.score++;
            //Debug.Log("score is" + gm.score);
        }
    }
}
