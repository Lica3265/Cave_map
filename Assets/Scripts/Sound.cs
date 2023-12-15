using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public float volume = 0.5f; 

    void Start()
    {
        audioSource.volume = volume;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
    
            volume = Mathf.Clamp01(volume + 0.1f);
            audioSource.volume = volume;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
     
            volume = Mathf.Clamp01(volume - 0.1f);
            audioSource.volume = volume;
        }
    }
}
