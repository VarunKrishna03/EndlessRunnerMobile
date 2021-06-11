using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //This script is to control camera resolution
    // Start is called before the first frame update
    public static float pixeltounit=1.0f;
    public static float scale=1.0f;
    public Vector2 nativeresolution = new Vector2(128, 128);
    private void Awake()
    {   
        var cam = GetComponent<Camera>();
        if(cam.orthographic)
        {
            scale = Screen.height / nativeresolution.y;
            pixeltounit *= scale;
            cam.orthographicSize = (Screen.height / 2.0f) / pixeltounit;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
