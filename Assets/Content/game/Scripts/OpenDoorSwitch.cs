using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorSwitch : MonoBehaviour
{
    public Door door;
    public float delayInSeconds;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag=="Player")
        {
            StopAllCoroutines();
            StartCoroutine(Animate());
        }
    }

    private IEnumerator Animate()
    {
        yield return new WaitForSeconds(delayInSeconds);

        door.Open();
    }
}
