using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFlip : MonoBehaviour
{
   

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
    }

    private void OnMouseDown()
    {
        FlipCard();
    }
}
