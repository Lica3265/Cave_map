using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;
    public float moveSpeed = 5f;
    public float detectionRange = 10f;
    public AudioSource audioSource;
    public AudioClip footstepSound;
    
    void Start()
    {
     
        navMeshAgent = GetComponent<NavMeshAgent>();
        if (navMeshAgent == null)
        {
          
            Debug.LogError("NavMeshAgent is missing on the monster object.");
        }
    }
    void Update()
    {
        if (player != null)
        {
      
            navMeshAgent.SetDestination(player.position);

       
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(footstepSound);
            }
            if (CanSeePlayer())
            {
              
                navMeshAgent.SetDestination(player.position);
                if (!audioSource.isPlaying)
                {
                    audioSource.PlayOneShot(footstepSound);
                }
            }
        }
    }
    bool CanSeePlayer()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, player.position - transform.position, out hit, detectionRange))
        {
            if (hit.collider.CompareTag("Player"))
            {
             
                return true;
            }
        }

    
        return false;
    }
}
