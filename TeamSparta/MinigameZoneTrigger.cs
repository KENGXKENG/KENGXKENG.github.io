using UnityEngine;

public class MinigameZoneTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("미니게임 존에 들어왔습니다!");
            FindObjectOfType<MainGameManager>().LoadMiniGameScene();
        }
    }
}
