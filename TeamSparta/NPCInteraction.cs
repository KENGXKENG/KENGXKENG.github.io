using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCInteraction : MonoBehaviour
{
    public GameObject dialoguePanel;


    public TextMeshProUGUI dialogueText;

    public string message = "Èû½ê°í °­ÇÑ ¾ÆÄ§! ¸¸ÀÏ ³»°Ô ¹¯´Â´Ù¸é ³ª´Â ¿Ðµµ!";

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            if (dialoguePanel != null && dialogueText != null)
            {
                dialoguePanel.SetActive(true);
                dialogueText.text = message;
                Debug.Log("E pressed and player is near");

            }
        }
    }


    private bool isPlayerNear = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            dialoguePanel.SetActive(false); // ³ª°¡¸é ´Ý±â
        }
    }

}
