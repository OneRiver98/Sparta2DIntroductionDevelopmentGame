using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterImageController : MonoBehaviour
{
    protected TopDownController controller;
    protected Animator Animator;
    protected SpriteRenderer characterSpriteRenderer;
    public Text nameText;

    protected virtual void Awake()
    {
        Animator = GetComponent<Animator>();
        controller = GetComponentInParent<TopDownController>();
        characterSpriteRenderer = GetComponent<SpriteRenderer>();
    }
}
