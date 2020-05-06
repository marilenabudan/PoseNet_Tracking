using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update

    private bool first = false;
    private float time;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wrist"))
        {
            if (!first)
            {
                Controller.Instance.ChangePrefabID();
                time = Time.time;
            }
            else if (Time.time - time >= 10f)
            {
                Controller.Instance.ChangePrefabID();
                time = Time.time;
            }
        }
    }
}
