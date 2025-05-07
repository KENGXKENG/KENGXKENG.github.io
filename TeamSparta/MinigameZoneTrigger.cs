using UnityEngine;

public class MinigameZoneTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�̴ϰ��� ���� ���Խ��ϴ�!");
            FindObjectOfType<MainGameManager>().LoadMiniGameScene();
        }
    }
}
