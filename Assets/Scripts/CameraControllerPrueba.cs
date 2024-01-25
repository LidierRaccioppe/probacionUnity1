using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Este script se encarga de controlar la cámara en un Roll a Ball
 */
public class CameraControllerPrueba : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset +  new Vector3 (12, 3, 22);
    }
}
