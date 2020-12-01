using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{
    public bool isRewinding = false;

    List<Vector3> positions;

    void Start()
    {
        positions = new List<Vector3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartRewind();
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopRewind(); 
        }
    }

    private void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else
            Record();
    }

    void Record()
    {
        if(positions.Count > Mathf.Round(5f / Time.fixedDeltaTime))
            positions.RemoveAt(positions.Count - 1);

        positions.Insert(0, transform.position);
    }

    void Rewind()
    {
        if (positions.Count > 0)
        {
            transform.position = positions[0];
            positions.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
    }

    public void StartRewind()
    {
        isRewinding = true;
    }
    public void StopRewind()
    {
        isRewinding = false;
    }
}
