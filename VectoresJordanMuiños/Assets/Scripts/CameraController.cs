using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
        cameras[0].SetActive(false);
        cameras[1].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
        cameras[0].SetActive(true);
        cameras[1].SetActive(false);
        }
    }
}

