using DialogueEditor;
using UnityEngine;

public class Scene : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ConversationManager.Instance.StartConversation(myConversation);
            }

        }
    }
}
