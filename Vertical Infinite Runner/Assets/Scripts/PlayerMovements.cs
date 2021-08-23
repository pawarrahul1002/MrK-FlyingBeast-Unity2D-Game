using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MrKGame
{
    /*summary : PlayerMovement will controls the movement of Player in three lanes also 
             constrain the direct movement, also checks for touch input*/
    public class PlayerMovements : MonoBehaviour
    {
        private Vector2 startTouchPosition, endTouchPosition;
        private float laneDistance = 1.5f;

        private void Update()
        {
            GettingTouchPos();
            LeftLanesInput();
            RightLanesInput();
        }

        /*GettingTouchPos : GettingTouchPos will check for touch position and apply constraints*/

        private void GettingTouchPos()
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startTouchPosition = Input.GetTouch(0).position;
            }

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                endTouchPosition = Input.GetTouch(0).position;
            }
        }

        /*LeftLanesInput : LeftLanesInput will check for left arrow press or leftswipe and move player to left*/
        private void LeftLanesInput()
        {
            if ((Input.GetKeyDown(KeyCode.LeftArrow) || (endTouchPosition.x < startTouchPosition.x)) && transform.position.x > -laneDistance)
            {
                transform.position = new Vector2(transform.position.x - laneDistance, transform.position.y);
                SoundManager.Instance.Play(Sounds.swipePlayer);
            }
        }


        /*RightLanesInput : LeftLanesInput will check for right arrow press or rightswipe and move player to right*/

        private void RightLanesInput()
        {
            if (((Input.GetKeyDown(KeyCode.RightArrow)) || (endTouchPosition.x > startTouchPosition.x)) && transform.position.x < laneDistance)
            {
                transform.position = new Vector2(transform.position.x + laneDistance, transform.position.y);
                SoundManager.Instance.Play(Sounds.swipePlayer);
            }

        }
    }

}