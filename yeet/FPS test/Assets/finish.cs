using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    public Transform target;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("kaugus").GetComponent<Text>().text = Distance().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("kaugus").GetComponent<Text>().text = Distance().ToString();
    }
    private float Distance()
    {
        return Vector3.Distance(target.position, player.position);
    }
}
