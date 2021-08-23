using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MrKGame
{

    /*summary : ScroreController class will controls the score which is showing in gameplay UI
                collecting coins and max time time will be the score*/
    public class ScroreController : MonoBehaviour
    {
        [SerializeField] public GameObject gameOverPanel;
        [SerializeField] public TextMeshProUGUI runText;
        [SerializeField] public TextMeshProUGUI coinText;
        [SerializeField] public TextMeshProUGUI WinText;
        private int score = 0;
        private float timeSpend = 0;

        void Update()
        {
            Timer();
        }

        /*Timer : In Timer method, will update the player run text to time spend*/
        void Timer()
        {
            timeSpend += Time.deltaTime;
            runText.text = timeSpend.ToString("0000");
        }


        /*OnTriggerEnter2D : In OnTriggerEnter2D method, will detect the collison of player with obstalce or coins
                                also update the text in UI and destroyes the collided object after collsion 
                                also plays sound for coin collect and game over if collided with obstacle*/
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                score++;
                coinText.text = "X " + score.ToString();
                SoundManager.Instance.Play(Sounds.CoinCollect);
            }
            else if (other.gameObject.CompareTag("Obstacle"))
            {
                SoundManager.Instance.Play(Sounds.GameOver);
                gameOverPanel.SetActive(true);
                WinText.text = "Mr.K You Got \n " + score.ToString() + " Coins In" + "\n" + timeSpend.ToString("0") + " Mtr Height";
                Time.timeScale = 0;
            }


            Destroy(other.gameObject);
        }
    }
}