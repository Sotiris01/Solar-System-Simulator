using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fragment_script : MonoBehaviour
{
    private float life = 3;
    private float speed = 10;
    private Vector3 dir;
    private Rigidbody rd;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        life += Time.time;

        dir = new Vector3(Random.Range(-1f, 1f), 
                            Random.Range(-1f, 1f),
                            Random.Range(-1f, 1f));
        rd.velocity = dir * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (life < Time.time)
        {
            Destroy(gameObject);
        }
    }
}
