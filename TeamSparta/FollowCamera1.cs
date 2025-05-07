using UnityEngine;

public class FollowCamera1 : MonoBehaviour
{
    public Transform target; // ���� ��� (�÷��̾�)
    public Vector2 minPosition; // ī�޶� �� �� �ִ� �ּ� ��ġ
    public Vector2 maxPosition; // ī�޶� �� �� �ִ� �ִ� ��ġ

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 newPosition = new Vector3(
                Mathf.Clamp(target.position.x, minPosition.x, maxPosition.x),
                Mathf.Clamp(target.position.y, minPosition.y, maxPosition.y),
                transform.position.z
            );
            transform.position = newPosition;
        }
    }
}
