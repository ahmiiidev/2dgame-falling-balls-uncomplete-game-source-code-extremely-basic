using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomobstical : MonoBehaviour
{

    public GameObject falling;
    public float plusx;
    public float minusx;
   /* public float plusy;
    public float minusy;*/
    public float timebetween;
    //this is of per frams falling
    private float fil;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > fil)
        {
            fall();
            fil = Time.time + timebetween;
        }
        
    }

    void fall()
    {
        float x = Random.Range(minusx, plusx);
       // float y = Random.Range(minusy, plusy);

        Instantiate(falling, transform.position + new Vector3(x, 0, 0), transform.rotation);
    }




}
