﻿using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;


    private void Awake()
    {
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction.normalized;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 15;

        movementRigidbody.velocity = direction;
    }
}
