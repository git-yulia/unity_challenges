using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject prefab_to_spawn;

    /// <summary>
    /// Just don't keep pressing spacebar because it 
    /// will KEEP MAKING ROGUE CUBES!!
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(prefab_to_spawn, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
