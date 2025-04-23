using Unity.Cinemachine;
using UnityEngine;

/// <summary>
/// ��ǻ� GameDirector ���ٴ� Manager��� �̸����� ���� ���δ�.
/// �ش� Ŭ������ ���׸� �̱��� Class(Singleton.cs ����) �Ͽ��⿡ �ڵ����� �̱��� �ν��Ͻ���
/// ������ �ȴ�.
/// ���� ��𼭵� GameManager�� ȣ���� �� ������, ���� �Ѿ�� �ı����� �ʰ� �����ȴ�.
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
