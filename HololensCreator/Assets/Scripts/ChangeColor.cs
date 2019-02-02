using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            count++;
            if (count%3==0)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.black;
            }
            if (count % 3 == 1)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            if (count % 3 == 2)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
        
    }
}
