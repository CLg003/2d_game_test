using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow_script : MonoBehaviour
{


    public Transform followTranform;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(followTranform.position.x, followTranform.position.y, this.transform.position.z);
    }
}
