using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // 動く速さ

    private Rigidbody rb; // Rididbody

    void Start()
    {
        // Rigidbody を取得
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // カーソルキーの入力を取得
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // カーソルキーの入力に合わせて移動方向を設定
        var movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Ridigbody に力を与えて玉を動かす
        rb.AddForce(movement * speed);
    }

    // 玉が他のオブジェクトにぶつかった時に呼び出される
    void OnTriggerEnter(Collider other)
    {
        // ぶつかったオブジェクトが収集アイテムだった場合
        if (other.gameObject.CompareTag("Pick Up"))
        {
            // その収集アイテムを非表示にします
            other.gameObject.SetActive(false);
        }
    }
}