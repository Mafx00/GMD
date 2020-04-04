using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public AudioSource onClickSound;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MustacheStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator MustacheStart()
    {
        yield return new WaitForSecondsRealtime(0);
        animator.enabled = true;
        yield return new  WaitForSecondsRealtime(2);
        animator.enabled = false;
    }
    public void StartButton()
    {
        onClickSound.Play();
        SceneManager.LoadScene(1);
    }
    public void ArenaButton()
    {
        onClickSound.Play();
        SceneManager.LoadScene(2);
    }
}
