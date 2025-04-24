using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        // 만약 과녁에 맞추었다면, GameManager에게 알려 카메라 전환
        if (collision.gameObject.CompareTag("Target"))
        {
            GameManager.Instance.HitTarget();
        }
        else
        {
            // 다시 발사 할 수 있게 설정
            // Target에 맞을 시에는 따로 카메라 전환후 CameraController.cs에서 설정해준다.
            GameManager.Instance.CanClick = true;
        }
    }

    void Start()
    {
        Application.targetFrameRate = 60;
        // Shoot(new Vector3(0, 200, 2000));
    }
}