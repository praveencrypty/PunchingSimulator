using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimator;
    float dragDistance;

    Vector2 startPosi, endPosi;
    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
        dragDistance = Screen.height * 20 / 100;

        print(dragDistance);
    }


    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
            {
                if (touch.phase == TouchPhase.Moved)
                {
                    startPosi = touch.position;

                    CheckEndTouchPoint(touch, "JabLeft");
                }               
                else
                {
                    playerAnimator.SetBool("PunchLeft", true);
                    EndAndReturnAnimation(touch);
                }

            }



            else if (touch.position.x > Screen.width / 2)
            {
                if (touch.phase == TouchPhase.Moved)
                {
                    startPosi = touch.position;

                    CheckEndTouchPoint(touch, "JabRight");
                }
                else
                {
                    playerAnimator.SetBool("PunchRight", true);
                    EndAndReturnAnimation(touch);
                }




            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerAnimator.SetBool("PunchRight", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            playerAnimator.SetBool("PunchRight", false);
        }
     
     
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnimator.SetBool("PunchLeft", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnimator.SetBool("PunchLeft", false);
        }
     
     
       if (Input.GetKeyDown(KeyCode.E))
       {
           playerAnimator.SetBool("JabRight", true);
       }
       if (Input.GetKeyUp(KeyCode.E))
       {
           playerAnimator.SetBool("JabRight", false);
       }
    
    
       if (Input.GetKeyDown(KeyCode.R))
       {
           playerAnimator.SetBool("JabLeft", true);
       }
       if (Input.GetKeyUp(KeyCode.R))
       {
           playerAnimator.SetBool("JabLeft", false);
       }

    }


    void CheckEndTouchPoint(Touch endTouch, string animName)
    {
        if (endTouch.phase == TouchPhase.Ended || endTouch.phase == TouchPhase.Canceled)
        {

            endPosi = endTouch.position;

            //print(Mathf.Abs(endPosi.y - startPosi.y));

            if (Mathf.Abs(endPosi.y - startPosi.y) > dragDistance)
            {
                print("Entered EndZone");
                playerAnimator.SetBool(animName, true);
                EndAndReturnAnimation(endTouch);
            }


        }
    }

    void EndAndReturnAnimation(Touch funcTouch)
    {
        if (funcTouch.phase == TouchPhase.Ended)
        {

            playerAnimator.SetBool("PunchRight", false);
            playerAnimator.SetBool("PunchLeft", false);
            playerAnimator.SetBool("JabRight", false);
            playerAnimator.SetBool("JabLeft", false);
        }
    }
}
