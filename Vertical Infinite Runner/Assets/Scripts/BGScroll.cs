using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrKGame
{
    /*summary : BG will move background down and change tranfrom to previous position
                after specific pos to give infinite runner background look */
    public class BGScroll : MonoBehaviour
    {
        private float scrollSpeed = 4f;
        private float maxDownDistance = -11f;
        private Vector3 startPos;

        void Start()
        {
            startPos = transform.position;
        }

        void Update()
        {
            BGScrolling();
        }


        /*BGScrolling : moving bg down with Translate and taking tranform to startPos after Max down distance */

        void BGScrolling()
        {
            transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
            if (transform.position.y < maxDownDistance)
            {
                transform.position = startPos;
            }

        }
    }
}