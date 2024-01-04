using UnityEngine;

public class EndGameOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Finish")) 
        {
            Debug.Log("G");
            EndGame();
        }
    }

    void EndGame()
    {


        Debug.Log("Game Over");
        Application.Quit(); 
    }
}
