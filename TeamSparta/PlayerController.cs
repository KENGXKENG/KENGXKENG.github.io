using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public UIManager uiManager;

    void Start()
    {
        if (uiManager == null)
        {
            uiManager = GameObject.FindObjectOfType<UIManager>();
        }

        if (uiManager != null)
            uiManager.ResetScore();
    }



    void Update()
    {
        // ���� �߰� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            uiManager.AddScore(1);
        }
    }

    public void OnGameOver()
    {
        uiManager.SetRestart();
    }
}
