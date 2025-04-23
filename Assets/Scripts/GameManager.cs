using Unity.Cinemachine;
using UnityEngine;

/// <summary>
/// 사실상 GameDirector 보다는 Manager라는 이름으로 많이 쓰인다.
/// 해당 클래스는 제네릭 싱글톤 Class(Singleton.cs 참고) 하였기에 자동으로 싱글톤 인스턴스가
/// 적용이 된다.
/// 언제 어디서든 GameManager를 호출할 수 있으며, 씬이 넘어가도 파괴되지 않고 유지된다.
/// </summary>

public class GameManager : Singleton<GameManager>
{
    public bool CanClick { get; set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanClick = true;
    }

}
