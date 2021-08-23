using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrKGame
{
    /*summary : Spawner class helps us in spawning coins and obstcles in game at specific pos of lane*/
    public class Spawner : MonoBehaviour
    {
        [SerializeField] public Transform spawnPos;
        [SerializeField] public GameObject coin;
        [SerializeField] public GameObject Obstacle;
        public float spawnTimer;
        private int startCoins;
        private int coinCount;
        private int coinNum;
        private Vector2 startSpawnPos;
        private Vector2 coinPos;
        private float[] pos = { -1.5f, 0f, 1.5f };


        /*Start : In async Start method, waiting for starting of SpawnningCoins using async await
                    and intializing varible after starting scene*/
        async void Start()
        {
            startSpawnPos = spawnPos.position;
            startCoins = 10;
            coinCount = 0;
            coinNum = 0;
            await new WaitForSeconds(1f);
            SpawnningCoins();
        }

        /*SpawnningCoins : In this mehtod, coin and obscales are spawn at
                            random position of three lanes,
                            at start it will spwan only coins to specific number and 
                            after that will spwan randomly between the coins or obstacle */

        private void SpawnningCoins()
        {
            coinPos = startSpawnPos;
            int numOfCoins = Random.Range(1, 5);

            if (coinCount > startCoins)
            {
                coinNum = Random.Range(0, 2);
            }

            if (coinNum == 0)
            {
                for (int i = 0; i < numOfCoins; i++)
                {
                    coinPos.x = pos[Random.Range(0, 3)];
                    Instantiate(coin, coinPos, Quaternion.identity);
                    coinPos.y += 1f;
                    coinCount++;
                }
            }
            else
            {
                coinPos.x = pos[Random.Range(0, 3)];
                Instantiate(Obstacle, coinPos, Quaternion.identity);
            }

            Invoke("SpawnningCoins", spawnTimer);
        }

    }
}