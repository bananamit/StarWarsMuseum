using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayo : MonoBehaviour
{
    public new Transform Camera;
    //int i = 0;
    int j = 0;
    //int k = 0;
    public float Range;

    public GameObject image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;
        layerMask= -layerMask;

        RaycastHit hit;
        if (Physics.Raycast(Camera.position, Camera.TransformDirection(Vector3.forward), out hit, Range))
        {

            Debug.DrawRay(Camera.position, Camera.forward * hit.distance, Color.blue);
            Debug.Log("Ha golpeado algo" + hit.collider.gameObject.name);

            if(hit.collider.gameObject.name=="R2D2")
            {
                j++;
                if(j % 2 == 0)
                {

                } 
                else{
                     image.SetActive(true);

                }
            }else
            {
                image.SetActive(false);
            }
    }

    
}}
