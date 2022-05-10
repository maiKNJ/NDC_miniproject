using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public Camera mainCam;
    public GameObject sceneLight;
    public Vector3 target;

  

    private void OnMouseOver()
    {
        //Quaternion target2 = Quaternion.Euler(target);
        //  mainCam.transform.localRotation = Quaternion.Slerp(mainCam.transform.localRotation,target2, Time.deltaTime * 1.0f);
        mainCam.transform.Rotate(target);
        sceneLight.transform.Rotate(target);
        //Debug.Log("hitting something");

    }

   
}
