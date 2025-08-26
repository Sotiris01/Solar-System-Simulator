using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor_movement : MonoBehaviour
{
    public int speed = 100;
    public GameObject fragment;


    private Vector3 dir;
    private Rigidbody rd;
    private GameObject sun;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("player");
        sun = GameObject.FindGameObjectWithTag("SUN");

        float size = Random.Range(1f, 10f);
        transform.localScale *= size;

        dir = (sun.transform.position - player.transform.position).normalized;
        rd.velocity = dir * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "planet")
        {
            Debug.Log("hit a planet");

            for (int i = 0; i < 30; i++)
            {
                GameObject frag = Instantiate(fragment, transform.position, Quaternion.identity);
                frag.GetComponent<Renderer>().material = other.gameObject.GetComponent<Renderer>().material;
            }

            Destroy(other.gameObject);
        }// else it will be the SUN


        for(int i=0; i<20; i++)
        {
            GameObject frag = Instantiate(fragment, transform.position, Quaternion.identity);
            frag.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
        }

        Destroy(gameObject);
    }

    
}
