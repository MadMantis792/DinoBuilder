using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullChanger : MonoBehaviour
{
    public Mesh [] dinosaurSkulls = new Mesh [2];
    public GameObject Huvud;
    int HeadCheck = 0; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchHead()
    {
        HeadCheck++;
        if (HeadCheck >= dinosaurSkulls.Length)
        {
            HeadCheck = 0;
        }


        gameObject.GetComponentInChildren<MeshFilter>().mesh = dinosaurSkulls[HeadCheck];

    }
}
