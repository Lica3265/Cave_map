using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem destructionParticles; // 將你的 Particle System 拖放到這個字段中

  
    public void PlayDestructionParticles()
    {
        if (destructionParticles != null)
        {
           
            destructionParticles.Play();

            
            gameObject.SetActive(false);
        }
    }
}
