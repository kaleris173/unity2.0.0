using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class shooter : MonoBehaviour
{
    public GameObject target;
    public GameObject bullet;
    private Rigidbody RB;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        RB = bullet.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.LookAt(target.transform);
        if (time >= 2)
        {
            time = 0;
            GameObject t = Instantiate(bullet, transform.position, Quaternion.identity);

            t.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
            Destroy(t, 3);
            

        }



    }
}
