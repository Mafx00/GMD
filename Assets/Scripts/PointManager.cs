using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private int score;

    public Slider healthBar;

    public GameObject winScreen;

    public GameObject loseScreen;

    public Text scoreText;

    public int enemieTotal;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "SHOOT"; 


    }

    // Update is called once per frame
    void Update()
    {
        if (score == enemieTotal)
        {
            winScreen.SetActive(true);
        }

        if (healthBar.value == 0)
        {
            loseScreen.SetActive(true);
        }

    }

    public void getPoint()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }
}
