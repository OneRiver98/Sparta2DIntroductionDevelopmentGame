using UnityEngine;

public class PlayerCharacterImageController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    private float magnituteThreshold = 0.1f;

    private int idle = 0;
    private int lookLeft = -1;
    private int lookRight = 1;


    protected override void Awake()
    { 
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnMoveEvent += LookLotation;
    }

    private void Move(Vector2 vector)
    {
        Animator.SetBool(IsWalking, vector.magnitude > magnituteThreshold);
    }

    private void LookLotation(Vector2 direction)
    {
        if(direction.x == idle) return;

        else if(direction.x == lookLeft)
        {
            if(characterSpriteRenderer.flipX) return;
            characterSpriteRenderer.flipX = true;
        }

        else if(direction.x == lookRight)
        {
            if(!characterSpriteRenderer.flipX) return;
            characterSpriteRenderer.flipX = false;
        }
    }
}