using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpineChanger : MonoBehaviour
{
    public Mesh [] dinosaurSpines = new Mesh[2];
    public GameObject Rygg;
    int SpineCheck = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchSpine()
    {
        SpineCheck++;
        if (SpineCheck >= dinosaurSpines.Length)
        {
            SpineCheck = 0;
        }


        gameObject.GetComponentInChildren<MeshFilter>().mesh = dinosaurSpines[SpineCheck];

    }
}
