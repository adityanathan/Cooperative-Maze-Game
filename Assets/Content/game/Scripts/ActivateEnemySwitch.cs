using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemySwitch : MonoBehaviour
{
    public Enemy enemy;
    public float delayInSeconds;

    void OnTriggerEnter(Collider collider)
    {
        // if (collider.GetComponent<IPlayerAvatar>() != null)
        if(collider.tag=="Player")
        {
            StopAllCoroutines();
            StartCoroutine(Animate());
        }
    }

    private IEnumerator Animate()
    {
        yield return new WaitForSeconds(delayInSeconds);

        enemy.enabled = true;
    }
}
