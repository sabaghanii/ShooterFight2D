using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int weaponIndex = 1;
    public int score = 0;
    public Text scoreText;

    private void Update()
    {
        scoreText.text = "Score : " + score;
    }
}
