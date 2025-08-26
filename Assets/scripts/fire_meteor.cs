using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_meteor : MonoBehaviour
{
    public GameObject meteor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(meteor, transform.position, Quaternion.identity);
        }
    }
}
