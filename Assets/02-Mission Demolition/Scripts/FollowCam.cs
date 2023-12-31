using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [Header("Set In Inspector")]
    public float easing = 0.05f;
    public Vector2 minxXY = Vector2.zero;
    static public GameObject POI;
    [Header("Set Dynamically")]
    public float camZ;

    void Awake()
    {
        camZ = this.transform.position.z;
    }
    void FixedUpdate()
    {
        if (POI == null) return;
        Vector3 destination = POI.transform.position;
        destination.x = Mathf.Max(minxXY.x, destination.x);
        destination.y = Mathf.Max(minxXY.y, destination.y);
        destination = Vector3.Lerp(transform.position, destination, easing);
        destination.z = camZ;
        transform.position = destination;
        Camera.main.orthographicSize = destination.y + 10;

        //Vector3 destination;
        //if (POI == null)
        //{
        //    destination = Vector3.zero;

        //}
        //else
        //{
        //    destination = POI.transform.position;
        //    if(POI.tag == "Projectile")
        //    {
        //        if (POI.GetComponent<Rigidbody>().IsSleeping())
        //        {
        //            POI = null;
        //            return;
        //        }
        //    }
        //}
        //destination.x = Mathf.Max(minxXY.x, destination.x);



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
