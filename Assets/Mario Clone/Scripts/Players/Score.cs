using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text cointTextScore;
    private AudioSource audioManager;
    private int scoreCount = 0;

    void Awake()
    {
        cointTextScore = GameObject.Find("CoinText").GetComponent<Text>();
        audioManager = GetComponent<AudioSource>();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == MyTags.COIN_TAG)
        {
            target.gameObject.SetActive(false);
            scoreCount++;
            cointTextScore.text = "x" + scoreCount;
            audioManager.Play();
        }
    }
}
