using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        GameManager.Instance.GameOver();
    }
}
