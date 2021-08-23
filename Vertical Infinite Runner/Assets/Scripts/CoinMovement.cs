using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrKGame
{
    /*summary : CoinMovement will controls the movement of coin after coin instantiate 
                also help in destrouing after max distnce*/
    public class CoinMovement : MonoBehaviour
    {
        private float coinFallSpeed;
        private float coinMaxPos = -7.0f;

        void Start()
        {
            coinFallSpeed = 5f;
        }
        void Update()
        {
            Move();
            CoinDestroyingIteself();
        }

        /*Move : this method helps in moving coins downword*/

        void Move()
        {
            Vector3 temp = transform.position;
            temp.y -= coinFallSpeed * Time.deltaTime;
            transform.position = temp;
        }


        /*CoinDestroyingIteself : this method helps in Destroying coin after coin max Pos*/
        private void CoinDestroyingIteself()
        {
            if (this.gameObject.transform.position.y < coinMaxPos)
            {
                Destroy(this.gameObject);
            }
        }
    }
}