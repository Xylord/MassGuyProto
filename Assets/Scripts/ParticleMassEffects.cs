using UnityEngine;
using System.Collections;

public class ParticleMassEffects : MonoBehaviour {

    public float particleSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float massEffect = MassGuy.mass;
        ParticleSystem.Particle[] p = new ParticleSystem.Particle[GetComponent<ParticleSystem>().particleCount + 1];

        int l = GetComponent<ParticleSystem>().GetParticles(p);

        for (int i = 0; i < l; i++)
        {
            p[i].velocity = new Vector3(0, massEffect * particleSpeed, 0);
        }

        GetComponent<ParticleSystem>().SetParticles(p, l);
    }
}
