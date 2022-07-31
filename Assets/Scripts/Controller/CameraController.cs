using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float smoothing;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 1.5f, -1);
        smoothing = 0.02f;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player != null)
        {
            if (transform.position != player.transform.position)
            {
                Vector3 targetPos = player.transform.position + offset;
                transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
            }
        }


    }


    void Update()
    {

    }
}
