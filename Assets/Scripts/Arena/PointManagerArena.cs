using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointManagerArena : MonoBehaviour
{
    private int score;

    public Slider healthBar;
    public GameObject player;
    public GameObject scoreResult;
    public GameObject initialUI;
    public Text scoreText;
    public Text finalResult;
    void Start()
    {
        score = 0;
        scoreText.text = "SHOOT";
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBar.value == 0)
        {
            // StartCoroutine(OpenFinalScore());
            scoreResult.SetActive(true);
            finalResult.text = "Final Result: " + score;
            initialUI.SetActive(false);
        }
    }

    public void getPoint()
    {
        score += 1;
        scoreText.text = "Enemies neutralized:" + score;
    }

    public IEnumerator OpenFinalScore()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);
    }
}


