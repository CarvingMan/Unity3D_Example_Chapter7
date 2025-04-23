using System.Collections;
using Unity.Cinemachine;
using UnityEngine;
/// <summary>
/// 시네머신을 활용한 카메라 컨트롤
/// </summary>
public class CameraController : MonoBehaviour
{
    [SerializeField, Tooltip("시작지점 카메라")]
    CinemachineCamera _startCam;
    [SerializeField, Tooltip("종료지점 카메라")]
    CinemachineCamera _endCam;
    private CinemachineBrain _brain = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(_startCam != null)
        {
            _startCam.transform.position = transform.position; // 메인카메라와 같은 위치
        }
        if (_brain == null)
        {
            _brain = GetComponent<CinemachineBrain>();
        }
    }

    void CameraMove()
    {
        GameManager.Instance.CanClick = false; // 카메라 움직일때는 발사 못하도록 설정
        _startCam.Priority = 0;
        _endCam.Priority = 1;
    }

    IEnumerator CorMoveCamera()
    {
        yield return null;
    }
}

/*
 *      // 카메라 전환이 끝났는지 확인
        if (brain.IsLive(camEnd) && !brain.IsLive(camStart))
        {
            Debug.Log("End 카메라로의 전환 완료!");
        }
        else if (brain.IsLive(camStart) && !brain.IsLive(camEnd))
        {
            Debug.Log("Start 카메라로의 전환 완료!");
        }
 */

/*
 * 
 * using UnityEngine;
using Unity.Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CinemachineCamera _startCam;
    [SerializeField] CinemachineCamera _endCam;

    private CinemachineBrain _brain;
    private bool _blendTriggered = false;

    void Start()
    {
        _brain = Camera.main.GetComponent<CinemachineBrain>();
        Invoke("CameraMove", 3f);
    }

    void CameraMove()
    {
        _startCam.Priority = 0;
        _endCam.Priority = 1;
        _blendTriggered = true;
    }

    void Update()
    {
        // 블렌딩이 완료된 시점 감지
        if (_blendTriggered && !_brain.IsBlending)
        {
            _blendTriggered = false; // 한 번만 실행되게
            Debug.Log("📸 카메라 블렌딩 완료!");
            
            // 여기서 원하는 작업 실행!
            // 예: 발사 허용, UI 전환 등
        }
    }
}

 */