using UnityEngine;

public class PlayerEffect : MonoBehaviour
{
    [Header("이펙트 설정")]
    public GameObject particlePrefab; // 생성할 파티클 프리팹
    public Transform spawnPoint;      // 파티클이 생성될 위치 (없으면 캐릭터 발밑)

    // 이 함수를 애니메이션 이벤트에서 호출할 것입니다.
    public void OnAttackEvent()
    {
        if (particlePrefab != null)
        {
            // 1. 생성 위치 결정 (spawnPoint가 있으면 거기서, 없으면 내 위치에서)
            Vector3 pos = spawnPoint != null ? spawnPoint.position : transform.position;
            Quaternion rot = spawnPoint != null ? spawnPoint.rotation : transform.rotation;

            // 2. 파티클 생성
            GameObject effect = Instantiate(particlePrefab, pos, rot);

            // 3. 2초 뒤 자동 삭제 (파티클 길이에 맞춰 조절)
            Destroy(effect, 1.0f);
        }
    }
}
