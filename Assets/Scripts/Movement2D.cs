using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;
    private float baseMoveSpeed;

    //public float MoveSpeed => moveSpeed;
    //moveSpeed 변수의 프로퍼티 (set,Get 가능)
    public float MoveSpeed
    {
        set => moveSpeed = Mathf.Max(0, value);
        get => moveSpeed;
    }

    public void Awake()
    {
        baseMoveSpeed = MoveSpeed;
    }

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3 direction)
    {
        moveDirection = direction;
    }

    public void ResetMoveSpeed()
    {
        moveSpeed = baseMoveSpeed;
    }
}
