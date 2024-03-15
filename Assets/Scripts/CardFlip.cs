using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFlip : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    private void OnMouseEnter()
    {
        StartCoroutine(FlipCards());
    }

    IEnumerator FlipCards()
    {
        animator.enabled = true;
        yield return null;
    }
}
