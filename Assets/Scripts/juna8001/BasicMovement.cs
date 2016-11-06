using UnityEngine;
using System.Collections;
using System;

public class BasicMovement : MonoBehaviour, IMovement
{
    Rigidbody body;

    public float CurrentVelocity
    {
        get
        {
            return body.velocity.magnitude;
        }
    }

    Vector2 direction;
    public Vector2 Direction
    {
        get
        {
            return direction;
        }

        set
        {
            direction = value.normalized;
        }
    }
    
    public float Rotation
    {
        get { return transform.eulerAngles.y; }
        set { transform.eulerAngles = new Vector3(0, value, 0); }
    }

    public bool IsMoving
    {
        get
        {
            return CurrentVelocity != 0;
        }
    }

    [SerializeField]
    float speed;
    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = Math.Abs(value);
        }
    }

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        body.velocity = new Vector3(direction.x, 0, direction.y) * speed;
    }

}
