using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droping : MonoBehaviour
{

    public GameObject dropin;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("dro", 4f , 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void dro()
    {
        Instantiate(dropin, transform.position, transform.rotation);
    }

}
