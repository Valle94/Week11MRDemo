using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;

    public void SpawnBall()
    {
        Instantiate(ballPrefab, transform.position, Quaternion.identity, transform);
    }

    public void DebugMessage()
    {
        Debug.Log("***Button Pressed!!***");
    }
}
