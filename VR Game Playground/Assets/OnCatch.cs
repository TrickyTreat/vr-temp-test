using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCatch : MonoBehaviour
{

    private GameObject one;
    private GameObject two;
    private bool cought = false;

    // Start is called before the first frame update
    void Start()
    {
        this.one = GameObject.FindGameObjectsWithTag("1")[0];
        this.two = GameObject.FindGameObjectsWithTag("2")[0];
        this.one.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Collider) {
        Debug.Log("sdfg");
        if(this.cought) {
            this.two.SetActive(true);
            this.one.SetActive(false);
            this.cought = false;
        }else {
            this.two.SetActive(false);
            this.one.SetActive(true);
            this.cought = true;
        }

    }
}
