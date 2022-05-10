using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 pos;
    public float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = Input.mousePosition;
        pos.z = speed;

        transform.position = Camera.main.ScreenToWorldPoint(pos);





        //var mousePos = Input.mousePosition;
        //var wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 15.0f));

        //transform.position = wantedPos;
        //Debug.Log("mouse position" + mousePos);
        //Debug.Log("wanted position" + wantedPos);
    }
}
