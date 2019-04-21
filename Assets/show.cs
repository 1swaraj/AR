using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show : MonoBehaviour {

    // Use this for initialization
    public GameObject p;
    public GameObject a;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void aable()
    {
        p.SetActive(true);
    }
    public void sable()
    {
        a.SetActive(true);
    }
    public void di()
    {
        p.SetActive(false);
        a.SetActive(false);
    }

    public void screens()
    {
        ScreenCapture.CaptureScreenshot("SomeLevel"+Random.Range(1,10)+".png");
    }
}
