using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class handleGunDamage : MonoBehaviour
{
    public gameManager gm;
    public Text scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GunBullet"))
        {
            //increment score
            gm.score++;
            scoreText.text = "Score : " + gm.score;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("rifleBullet"))
        {
            //increment 5 scores
            gm.score = gm.score + 5;
            scoreText.text = "Score : " + gm.score;
            Destroy(gameObject);
        }
    }
}
