using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateParticlesOnCollision : MonoBehaviour
{
    public ParticleSystem ps;
    private void OnCollisionEnter(Collision collision)
    {
        ps.Play();
    }
}
