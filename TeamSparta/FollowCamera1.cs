using UnityEngine;

public class FollowCamera1 : MonoBehaviour
{
    public Transform target; // 따라갈 대상 (플레이어)
    public Vector2 minPosition; // 카메라가 갈 수 있는 최소 위치
    public Vector2 maxPosition; // 카메라가 갈 수 있는 최대 위치

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
