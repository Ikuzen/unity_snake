using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segment : MonoBehaviour
{
    public Segment previous;
    public Segment next;
    private static float dist = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (previous)
        {
            Vector3 v = (previous.transform.position - transform.position);
            if (v.magnitude > dist)
                transform.position += v.normalized * 0.02f;


        }
        else if(Control.instance)
        {
            Vector3 v = (Control.instance.transform.position- transform.position);
            if (v.magnitude > dist)
                transform.position += v.normalized * 0.02f;

        }
    }
}
