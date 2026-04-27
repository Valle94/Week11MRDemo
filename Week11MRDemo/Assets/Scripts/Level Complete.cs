using UnityEngine;

public class LevelComplete : MonoBehaviour
{
   [SerializeField] ParticleSystem hooray;

    void Start()
    {
        hooray.Stop();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            hooray.Play();
        }
    }
}
