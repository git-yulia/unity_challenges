using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        // When we instantiate a new cube, we want 
        // the camera to shake, since this is a dramatic
        // event. 
        //
        int shake_iterations = 30;
        float rotation_amount = 2F; 
        float time_between_rotations = .005F; 
        for (int i = 0; i < shake_iterations; i++)
        {
            // Applies a rot. of eulerangles.N around the N axis
            this.transform.Rotate(0, 0, rotation_amount);
            yield return new WaitForSeconds(time_between_rotations);
            this.transform.Rotate(0, 0, 0);
            yield return new WaitForSeconds(time_between_rotations);
            this.transform.Rotate(0, 0, -rotation_amount);
            yield return new WaitForSeconds(time_between_rotations);
            this.transform.Rotate(0, 0, 0);
            yield return new WaitForSeconds(time_between_rotations);
        }
    }
}
