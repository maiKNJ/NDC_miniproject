using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryAppear : MonoBehaviour
{
    public Canvas scary;
    public AudioSource laugh;
    bool scarAp = true;
    bool test = false;


    private void Start()
    {
        scary.enabled = false;
    }

    void Update()
    {
        if (scarAp)
        {
         StartCoroutine(Appear());
        }
        if (test)
        {
            StartCoroutine(Disappear());
        }

    }

    IEnumerator Appear()
    {
        scarAp = false;
        yield return new WaitForSeconds(Random.Range(10, 30));
        laugh.Play(0);
        scary.enabled = true;
        test = true;

    }

    IEnumerator Disappear()
    {
        test = false;
        yield return new WaitForSeconds(2);
        scary.enabled = false;
        scarAp = true;

    }

}
