using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
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

    public void SettingsButton()
    {
        onClickSound.Play();
        SceneManager.LoadScene(5);
    }
    public void ReturnToStart()
    {
        onClickSound.Play();
        SceneManager.LoadScene(0);
    }


  /* public void SetSoundOn()
    {
        mixer.SetFloat("sound", -5);
    }
    public void SetSoundOff()
    {
        mixer.SetFloat("sound", -80);
    } */
}
