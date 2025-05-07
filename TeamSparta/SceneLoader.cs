using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string targetSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�̴ϰ��� ���� ���Խ��ϴ�!");
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
