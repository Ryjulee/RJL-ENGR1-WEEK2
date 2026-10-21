using UnityEngine;

public class coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlatformerController player = collision.GetComponent<PlatformerController>();
            player.coinsCollected++;
            Debug.Log("coin collected!");
            Debug.Log("player score: " + player.coinsCollected);
            Destroy(gameObject);
        }
    }
}
