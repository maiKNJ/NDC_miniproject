using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    //public AudioSource audio;
    //public GameObject spook;
   

    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }
        
    }

    IEnumerator FlickeringLight()
    {
        
        yield return new WaitForSeconds(3f);
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        //audio.Play(0);
        //spook.SetActive(false);

        //timeDelay = Random.Range(0.05f, 5f);
       // Debug.Log("off");
        yield return new WaitForSeconds(0.5f);
        this.gameObject.GetComponent<Light>().enabled = true;
        //timeDelay = Random.Range(0.05f, 5f);
        //Debug.Log("on");
        //yield return new WaitForSeconds(0.02f);
        //yield return new WaitForSeconds(10f);
        //spook.SetActive(true);
        yield return new WaitForSeconds(10f);
        this.gameObject.GetComponent<Light>().enabled = true;
        //audio.Stop();
        
        isFlickering = false;
    }
}
