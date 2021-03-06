using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{

    [Tooltip("Death Delay")] [SerializeField] float deathDelay;
    [Tooltip("Death Particle for Player Ship")] [SerializeField] ParticleSystem deathParticles;

    private void Awake()
    {
        ParticleSystem.EmissionModule death = deathParticles.emission;
        death.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Transition());
    }

    private void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    IEnumerator Transition()
    {
        ParticleSystem.EmissionModule death = deathParticles.emission;
        StartDeathSequence(death);
        yield return new WaitForSeconds(deathDelay);
        ResolveDeathSequence(death);
    }

    private void StartDeathSequence(ParticleSystem.EmissionModule death)
    {
        death.enabled = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<PlayerControls>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }

    private void ResolveDeathSequence(ParticleSystem.EmissionModule death)
    {
        ScoreBoard.ResetScore();
        death.enabled = false;
        GetComponent<MeshRenderer>().enabled = true;
        ReloadScene();
        GetComponent<PlayerControls>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;
    }
}
