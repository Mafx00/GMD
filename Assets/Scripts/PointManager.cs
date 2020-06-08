using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private int score;

    public Slider healthBar;
    public GameObject player;
    public GameObject edgeWall;
    public GameObject bossScene;
    public AudioSource explosionSound;


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

            player.SetActive(false);
            SceneManager.LoadScene(3);
        }

        if (score == enemieTotal + 1)
        {
            StartCoroutine(OpenWinScreen());
        }

    
            loseScreen.SetActive(true);
        }



    public void getPoint()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    public IEnumerator OpenWinScreen()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);
    }
}
