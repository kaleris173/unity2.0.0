using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opener : MonoBehaviour
{
    public GameObject character;
    public float Distance;
    private Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { if (Vector3.Distance (character.transform.position,transform.position)<Distance)
        {
            anime.SetBool("character_nearby", true);
        }
        else
        {
            anime.SetBool("character_nearby", false);
        }
    }
}
