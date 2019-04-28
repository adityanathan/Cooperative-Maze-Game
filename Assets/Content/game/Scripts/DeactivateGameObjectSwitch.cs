using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateGameObjectSwitch : MonoBehaviour
{
    public GameObject gameObjectToDeactivate;
    public float delayInSeconds;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag=="Player" && gameObjectToDeactivate.activeInHierarchy)
        {
            StopAllCoroutines();
            StartCoroutine(RemovePlatform());
        }
    }

    private IEnumerator RemovePlatform()
    {
        yield return new WaitForSeconds(delayInSeconds);

        gameObjectToDeactivate.SetActive(false);
    }
}
