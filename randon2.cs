using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randon2 : MonoBehaviour
{

    public GameObject inxasix;
    public float plusx;
    public float minusx;
    public float plusy;
    public float minusy;
    public float Timeofsend;
    private float fram;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > fram)
        {
            sna();
            fram = Time.time + Timeofsend;
        }

    }

    void sna()
    {

        float x = Random.Range(plusx, minusx);
        float y = Random.Range(plusy, minusy);

        Instantiate(inxasix, transform.position + new Vector3(x, y, 0), transform.rotation);

    }
}
