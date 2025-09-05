using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
	[SerializeField] string nextScene;
	[SerializeField] GameManager gameManager;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		
		if (gameManager.coinsCollected >= 5)
			{
				SceneManager.LoadScene(nextScene);
			}
	}
}
