using UnityEngine;

public class Coin : MonoBehaviour
{
	[SerializeField] GameManager gameManager;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		gameManager.CoinCollected();
		Destroy(gameObject);
	}
}
