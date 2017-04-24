using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour {

    public float minSwipeDistY = 0.1f;

    public float minSwipeDistX = 0.1f;

    private Vector2 startPos;

    public bool movingRight = false;
    public bool movingLeft = false;

    // Use this for initialization
    void Start () {
		
	}



    void Update()
    {
        //#if UNITY_ANDROID
        if (Input.touchCount > 0)

        {

            Touch touch = Input.touches[0];



            switch (touch.phase)

            {

                case TouchPhase.Began:
                    movingLeft = false;
                    movingRight = false;

                    startPos = touch.position;

                    break;



                case TouchPhase.Ended:

                    float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;

                    if (swipeDistVertical > minSwipeDistY)

                    {

                        float swipeValue = Mathf.Sign(touch.position.y - startPos.y);

                        if (swipeValue > 0)
                        {//up swipe

                            //Jump ();
                        }

                        else if (swipeValue < 0)
                        {//down swipe

                            //Shrink ();
                        }

                    }

                    float swipeDistHorizontal = (new Vector3(touch.position.x, 0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;

                    if (swipeDistHorizontal > minSwipeDistX)

                    {

                        float swipeValue = Mathf.Sign(touch.position.x - startPos.x);

                        if (swipeValue > 0)
                        {//right swipe
                            movingRight = true;
                            //MoveRight ();
                        }

                        else if (swipeValue < 0)
                        {//left swipe

                            movingLeft = true;

                            //MoveLeft ();
                        }

                    }
                    break;
            }
        }
    }
}
