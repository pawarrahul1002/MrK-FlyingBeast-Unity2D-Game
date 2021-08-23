// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// namespace MrKGame
// {

//     /*summary : PlayerMovement will controls the movement of Player in three lanes also 
//                 constrain the direct movement*/
//     public class PlayerMovement : MonoBehaviour
//     {
//         private int lane;
//         private float middleLanePos = 0f;
//         private float laneDistance = 1.5f;

//         /*Lane : this is enum help for stroing lane type */
//         private enum Lane
//         {
//             left,
//             middle,
//             right
//         }

//         /*Start : In start method, setting player to middle lane */

//         private void Start()
//         {
//             lane = (int)Lane.middle;
//         }

//         void Update()
//         {
//             Movement();
//         }

//         /*Movement : In Movement method, getting input for player movement and calling specific methods */
//         void Movement()
//         {
//             if (Input.GetKeyDown(KeyCode.LeftArrow))
//             {
//                 MovementForLeftArrow();

//             }
//             if (Input.GetKeyDown(KeyCode.RightArrow))
//             {
//                 MovementForRightArrow();
//             }

//         }


//         /*MovementForLeftArrow : In MovementForLeftArrow method, controlling movement for left arrow and contraining the pos of player */

//         private void MovementForLeftArrow()
//         {
//             if (lane == (int)Lane.right)
//             {
//                 MovementToMiddle();

//             }
//             else if (lane == (int)Lane.middle)
//             {
//                 MovementToLeft();
//             }
//         }


//         /*MovementForRightArrow : In MovementForRightArrow method, controlling movement for right arrow and contraining the pos of player */

//         private void MovementForRightArrow()
//         {
//             if (lane == (int)Lane.left)
//             {
//                 MovementToMiddle();
//             }
//             else if (lane == (int)Lane.middle)
//             {
//                 MovementToRight();
//             }
//         }

//         /*MovementToMiddle : In MovementToMiddle method, player will move to middle lane and setting lane varible to middle lane */

//         private void MovementToMiddle()
//         {
//             transform.position = new Vector2(middleLanePos, transform.position.y);
//             lane = (int)Lane.middle;
//         }


//         /*MovementToLeft : In MovementToLeft method, player will move to left lane and setting lane varible to left lane */
//         private void MovementToLeft()
//         {
//             transform.position = new Vector2((middleLanePos - laneDistance), transform.position.y);
//             lane = (int)Lane.left;
//         }


//         /*MovementToRight : In MovementToRight method, player will move to right lane and setting lane varible to right lane */
//         private void MovementToRight()
//         {
//             transform.position = new Vector2((middleLanePos + laneDistance), transform.position.y);
//             lane = (int)Lane.right;
//         }
//     }
// }