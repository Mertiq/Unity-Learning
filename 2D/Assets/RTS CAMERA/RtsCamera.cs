using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RtsCamera : MonoBehaviour
{
    public Camera cam;

    public float panSpeed = 20f;
    public float panBorderThickness = 10f;

    public Vector2 panLimit;
    public float maxSize;
    public float minSize;

    public float scrollSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll =  Input.GetAxis("Mouse ScrollWheel");
        float size = cam.orthographicSize;
        size -= scroll * scrollSpeed * 1000f * Time.deltaTime;
        cam.orthographicSize = Mathf.Clamp(size, minSize, maxSize);

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, -panLimit.y, panLimit.y);
        
        
        transform.position = pos;
    }
}
