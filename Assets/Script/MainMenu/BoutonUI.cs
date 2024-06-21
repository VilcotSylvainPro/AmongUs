using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonUI : MonoBehaviour
{


    [SerializeField] AudioClip hoverSound;
    [SerializeField] AudioSource MySounds;
    [SerializeField] AudioClip onClickSound;
    [SerializeField] AudioClip Voted;
    [SerializeField] AudioClip OnClickButtonVote;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void HoverSound()
    {
        MySounds.PlayOneShot(hoverSound);
    }

    public void OnClickSound()
    {
        MySounds.PlayOneShot(onClickSound);
    }

    public void OnClickVote()
    {
        MySounds.PlayOneShot(OnClickButtonVote);
    }

    public void OnClickVoteConfirm()
    {
        MySounds.PlayOneShot(Voted);
    }



    public void LaunchGame() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
