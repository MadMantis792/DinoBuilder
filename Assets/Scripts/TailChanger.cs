using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailChanger : MonoBehaviour
{
    public Mesh[] dinosaurTails = new Mesh[2];
    public GameObject Svans;
    int TailCheck = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchTail()
    {
        TailCheck++;
        if (TailCheck >= dinosaurTails.Length)
        {
            TailCheck = 0;
        }


        gameObject.GetComponentInChildren<MeshFilter>().mesh = dinosaurTails[TailCheck];

    }
}
