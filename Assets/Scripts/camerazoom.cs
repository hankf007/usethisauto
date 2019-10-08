using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour
{

    //  public float cameraDistanceMax;
    // public float cameraDistanceMin ;
    // public float cameraDistance;
    // public float scrollSpeed;
    public float zoom;
    public float zoomspeed;


    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {

        zoom = Mathf.Clamp(zoom, 30f, 80f); //set zoom limit

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
           zoom= zoom - zoomspeed ;
            GetComponent<Camera>().fieldOfView = zoom;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
           zoom= zoom+zoomspeed;
            GetComponent<Camera>().fieldOfView = zoom;
        }


    }
}
