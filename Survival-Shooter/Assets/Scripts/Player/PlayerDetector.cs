using UnityEngine;

public class PlayerDetector : MonoBehaviour {
    public GameOverManager gameOverManager;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Enemy" && !other.isTrigger && transform.GetComponent<PlayerHealth>().currentHealth > 0) {
            float enemyDistance = Vector3.Distance(transform.position, other.transform.position);
            gameOverManager.ShowWarning(enemyDistance);
        }
    }
}