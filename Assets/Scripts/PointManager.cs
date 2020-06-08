using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    private int score;

    public Slider healthBar;
<<<<<<< HEAD
    public GameObject player;
    public GameObject edgeWall;
    public GameObject bossScene;
    public AudioSource explosionSound;
=======

    public GameObject winScreen;

    public GameObject loseScreen;

>>>>>>> parent of f3f2fbf... Enemies and weapons working
    public Text scoreText;

    public int enemieTotal;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "SHOOT"; 
<<<<<<< HEAD
=======


>>>>>>> parent of f3f2fbf... Enemies and weapons working
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
<<<<<<< HEAD
            player.SetActive(false);
            SceneManager.LoadScene(3);
        }

        if (score == enemieTotal+1)
        {
            StartCoroutine(OpenWinScreen());
        }

=======
            loseScreen.SetActive(true);
        }

>>>>>>> parent of f3f2fbf... Enemies and weapons working
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
