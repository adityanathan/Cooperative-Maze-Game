using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateGameObjectSwitch : MonoBehaviour
{
    public GameObject gameObjectToAnimate;
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
         gameObjectToAnimate.GetComponent<Animator>().SetBool("SwitchTriggered", true);

    }
}
