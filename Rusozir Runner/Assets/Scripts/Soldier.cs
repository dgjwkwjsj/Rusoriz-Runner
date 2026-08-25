using System;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    [SerializeField] private float speedClip = 0.5f;
    [SerializeField] private float acceleration = 0.1f;
    [SerializeField] private float timer = 2f;


    private Animator animator;
    private float currentTime;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = speedClip;
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= timer)
        {
            speedClip += acceleration;
            animator.speed = speedClip;

            currentTime = 0f;
        }
    }

}
