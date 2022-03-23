using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // ��������

    private Rigidbody rb; // Rididbody

    void Start()
    {
        // Rigidbody ���擾
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // �J�[�\���L�[�̓��͂��擾
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // �J�[�\���L�[�̓��͂ɍ��킹�Ĉړ�������ݒ�
        var movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Ridigbody �ɗ͂�^���ċʂ𓮂���
        rb.AddForce(movement * speed);
    }

    // �ʂ����̃I�u�W�F�N�g�ɂԂ��������ɌĂяo�����
    void OnTriggerEnter(Collider other)
    {
        // �Ԃ������I�u�W�F�N�g�����W�A�C�e���������ꍇ
        if (other.gameObject.CompareTag("Pick Up"))
        {
            // ���̎��W�A�C�e�����\���ɂ��܂�
            other.gameObject.SetActive(false);
        }
    }
}