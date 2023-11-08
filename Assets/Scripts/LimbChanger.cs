using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbChanger : MonoBehaviour
{
    public Mesh[] dinosaurLimbs = new Mesh[2];
    public GameObject Lemmar;
    int LimbCheck = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchLimb()
    {
        LimbCheck++;
        if (LimbCheck >= dinosaurLimbs.Length)
        {
            LimbCheck = 0;
        }


        gameObject.GetComponentInChildren<MeshFilter>().mesh = dinosaurLimbs[LimbCheck];

    }
}
