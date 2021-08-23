// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SwipePlayer : MonoBehaviour
// {

//     private Vector2 startTouchPosition, endTouchPosition;


//     private void Update()
//     {
//         if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
//             startTouchPosition = Input.GetTouch(0).position;

//         if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
//         {
//             endTouchPosition = Input.GetTouch(0).position;

//             if ((Input.GetKeyDown(KeyCode.LeftArrow) || (endTouchPosition.x < startTouchPosition.x)) && transform.position.x > -1.5f)
//                 transform.position = new Vector2(transform.position.x - 1.5f, transform.position.y);

//             if (((Input.GetKeyDown(KeyCode.RightArrow)) || (endTouchPosition.x > startTouchPosition.x)) && transform.position.x < 1.5f)
//                 transform.position = new Vector2(transform.position.x + 1.5f, transform.position.y);
//         }
//     }
// }
