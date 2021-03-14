using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimHandler : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    /// <summary>
    /// If you change the name of an animation clip 
    /// in the project, you must make sure it matches
    /// the name in the Animator window. 
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.Play("breathing");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            animator.Play("pacing");
        }
    }
}
