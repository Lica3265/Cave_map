using UnityEngine;

public class WallHealth : MonoBehaviour
{
    private float health = 20f;
    public AudioClip hitSound; 
    public AudioClip destroySound; 
    private AudioSource audioSource;

    void Start()
    {
   
        audioSource = GetComponent<AudioSource>();
    }

   
    public void SetHealth(float initialHealth)
    {
        health = initialHealth;
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckForClick();
        }
    }

    void CheckForClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
          
            if (hit.transform.gameObject == gameObject)
            {
                Damage(10f); 
                PlayHitSound();
            }
        }
    }

  
    public void Damage(float amount)
    {
        health -= amount;
        Debug.Log("Wall health: " + health);

      
        if (health <= 0f)
        {
            DestroyWall();
        }
    }

  
    void PlayHitSound()
    {
        if (audioSource && hitSound)
        {
            audioSource.PlayOneShot(hitSound);
            Debug.Log("hit sound played!");
        }
    }

   
    void DestroyWall()
    {
        if (audioSource && destroySound)
        {
            audioSource.PlayOneShot(destroySound);
            Debug.Log("Destroy sound played!");
        }

        Destroy(gameObject);
    }
}
