using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init_Cube : MonoBehaviour
{

    public Cube cube;
    public Sprite sprite;
    void Start()
    {
    }
    float x = 0;
    private void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;

        //gameObject.GetComponent<SpriteRenderer>().color = cube.color;
        x += Time.deltaTime;
        if (cube.canMove && x>5)
        {
            Vector3 v =  new Vector3(1f, 1f,0f);
            transform.position += v;
            x = 0;
        }
    }


}
