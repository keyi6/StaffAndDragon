using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(6, 1, -1);

    // Start is called before the first frame update
    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
