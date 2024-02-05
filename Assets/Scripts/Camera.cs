using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    void LateUpdate()
    {
        // Only follow x and z, make y a constant for better view
        transform.position = new Vector3(player.transform.position.x + 6, 8, player.transform.position.z - 1);
    }
}
