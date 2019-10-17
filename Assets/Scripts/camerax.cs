using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerax : MonoBehaviour
{
    public float xMoveThreshold = 1000.0f;
    public float yMoveThreshold = 1000.0f;

    public float yMaxLimit = 120f;
    public float yMinLimit = 60f;


    float yRotCounter = 0.0f;
    float xRotCounter = 180;

    public Transform target;

    public Transform player;
    


    void Start()
    {
        //player = Camera.main.transform;

    }

    // Update is called once per frame
    void Update()
    {
        xRotCounter += Input.GetAxis("Mouse X") * xMoveThreshold * Time.deltaTime;
        yRotCounter += Input.GetAxis("Mouse Y") * yMoveThreshold * Time.deltaTime;
        yRotCounter = Mathf.Clamp(yRotCounter, yMinLimit, yMaxLimit);
        //xRotCounter = xRotCounter % 360;//Optional
        target.localEulerAngles = new Vector3(-yRotCounter, xRotCounter, 0);

        
        Vector3 newpos = (player.position+ new Vector3(0, 5, 0));
        this.transform.position = newpos;
    }
}
