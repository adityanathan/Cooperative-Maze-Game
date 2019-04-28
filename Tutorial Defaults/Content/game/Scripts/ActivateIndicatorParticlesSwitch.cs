using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateIndicatorParticlesSwitch : MonoBehaviour
{
    public GameObject m_ParticleSystemGameObject;

    void OnTriggerEnter(Collider collider)
    {
        if((collider.tag=="Player") && !m_ParticleSystemGameObject.activeInHierarchy)
        {
            m_ParticleSystemGameObject.SetActive(true);
        }
    }
}
