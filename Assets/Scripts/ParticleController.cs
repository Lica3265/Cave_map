using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem destructionParticles; // �N�A�� Particle System ����o�Ӧr�q��

  
    public void PlayDestructionParticles()
    {
        if (destructionParticles != null)
        {
           
            destructionParticles.Play();

            
            gameObject.SetActive(false);
        }
    }
}
