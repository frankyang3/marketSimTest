using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private Animator playeranim;
    // Start is called before the first frame update
    void Start()
    {
        playeranim = GetComponent<Animator>();
        playeranim.Play
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);
    }
}
