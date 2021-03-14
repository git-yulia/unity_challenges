using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is just a reference for how and when the 
/// MonoBehaviour lifecycle components are called. 
/// </summary>
public class MonoLifecycleExample : MonoBehaviour
{
    //------------------------------//
    // INITIALIZATION
    //------------------------------//

    private void Awake()
    {
        // Called before any Start functions
        // Called just after a prefab is instantiated
        // Not called until a GameObj is made active
    }

    private void OnEnable()
    {
        // Called just after the object is enabled
        // For example, when a level is loaded
        // Or a GameObj is instantiated
    }

    //------------------------------//
    // EDITOR
    //------------------------------//

    private void Reset()
    {
        // When the script is first attached to a GameObject
        // Or when the reset command is called from the editor. 
    }

    private void OnValidate()
    {
        // Whenever script properties are set
        // Like when an object is deserialized
        // For instance, when you open a scene in the editor
    }

    //------------------------------//
    // INITIALIZATION
    //------------------------------//

    private void Start()
    {
        // Called before the first frame update
    }

    //------------------------------//
    // PHYSICS
    //------------------------------//

    private void FixedUpdate()
    {
        // Can be called more than once per frame
        // FixedUpdate is called on a reliable timer, independent of the frame rate.
    }

    // internal animation updates.. 
    // too many to list.....

    private void OnTrigger()
    {
    }
    private void OnCollision()
    {
    }

    // yield WaitForFixedUpdate

    //------------------------------//
    // INPUT EVENTS
    //------------------------------//

    private void OnMouseXXX()
    {
    }

    //------------------------------//
    // GAME LOGIC
    //------------------------------//

    private void Update()
    {
        // Called once per frame
    }

    // yield 
    // - coroutine continues after all Update functions have been called 
    //   on the next frame. So it yields for one frame?
    //
    // yield null
    // - ?
    //
    // yield WaitForSeconds
    // - continues after a specific time delay and after update functions
    //   are complete for the frame. 
    //
    // yield WWW
    // - continues after a WWW download has completed
    //
    // yield StartCoroutine
    // - chains the coroutine, and waits for the next guy to complete first. 
    //

    private void LateUpdate()
    {
        // Called once per frame after update is finished
        // Would be useful for a 3rd person camera that 
        // tracks a player. Movement/rot calculations for the 
        // camera could occur in LateUpdate
    }

    //------------------------------//
    // SCENE RENDERING
    //------------------------------//

    // A bunch of render steps... 
    // Use the frame debugger to analyze
    // this process in more detail.

    //------------------------------//
    // GIZMO RENDERING
    //------------------------------//

    // Editor only.

    private void OnDrawGizmos()
    {
    }

    //------------------------------//
    // GUI RENDERING
    //------------------------------//

    private void OnGUI()
    {
    }

    //------------------------------//
    // END OF FRAME
    //------------------------------//

    // yield WaitForEndOfFrame

    //------------------------------//
    // PAUSING
    //------------------------------//

    private void OnApplicationPause()
    {
        Debug.Log("Application was paused.");
        // One extra frame is issued after this 
        // is called to show graphics that indicate
        // the paused state. 
    }

    //------------------------------//
    // DECOMMISSIONING
    //------------------------------//

    private void OnApplicationQuit()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
        // in response to destroying object or closing scene
    }
}
