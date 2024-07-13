using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{

   public float speeding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        mov();
    }

    void mov()
    {

        float a = Input.GetAxis("Horizontal") *Time.deltaTime * speeding;
       // float b = Input.GetAxis("Vertical");

        transform.Translate(a, 0, 0);


    }
}
