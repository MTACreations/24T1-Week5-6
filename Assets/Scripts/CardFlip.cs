using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFlip : MonoBehaviour
{
    public Timer timer;

    private void Start()
    {
       
    }

    
   /* IEnumerator FlipCards()
    {
      //  animator.enabled = true;
       // yield return null;
    }
   */

    private void FlipCard()
    {
        gameObject.transform.Rotate(0,-180,0,Space.Self);

        if(gameObject.tag == "Time Card")
        {
            timer.ChangeTime(15);
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        FlipCard();
    }
}
