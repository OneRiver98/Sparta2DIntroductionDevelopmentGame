using System;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected TopDownController controller;
    protected Animator Animator;
    protected SpriteRenderer characterSpriteRenderer;

    protected virtual void Awake()
    {
        Animator = GetComponent<Animator>();
        controller = GetComponentInParent<TopDownController>();
        characterSpriteRenderer = GetComponent<SpriteRenderer>();
    }
}
