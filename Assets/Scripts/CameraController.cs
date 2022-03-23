using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject player; // �ʂ̃I�u�W�F�N�g

    private Vector3 offset; // �ʂ���J�����܂ł̋���

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}