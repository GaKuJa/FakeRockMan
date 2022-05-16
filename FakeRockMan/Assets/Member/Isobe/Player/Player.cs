using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get => _instance; }
    static Player _instance;
    [SerializeField, Header("PlayerHP")]
    public int PlayerHP = 10;
    bool R;
    SpriteRenderer spriteRenderer;
    [SerializeField, Header("")]
    float horizontal = 10f;
    [SerializeField, Header("")]
    float Verttical = 10f;

    bool _AtkTimer = true;
    //トリガー左
    //トリガー右
    //トリガー下（ジャンプ）
    [SerializeField]
    PlayerTrigger playerTrigger;
    [SerializeField]
    GameObject gameobj;
    Rigidbody2D rigidbody2D;
    void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (PlayerHP == 0)
        {
            //死亡処理
            gameObject.SetActive(false);
        }
        if(Input.GetKey(KeyCode.A))
        {
            R = false;
            rigidbody2D.AddForce(new Vector2(-horizontal, 0));
            spriteRenderer.flipX=true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            R = true;
            rigidbody2D.AddForce(new Vector2(horizontal, 0));
            spriteRenderer.flipX = false;
        }
        //地面に触れている場合
        if (Input.GetKey(KeyCode.Space) && playerTrigger.jumpTrigger)
        {
            rigidbody2D.AddForce(new Vector2(0, Verttical));
        }
        //攻撃方法（入力方法）変更予定
        if (Input.GetKey(KeyCode.Mouse0)&&_AtkTimer)
        {
            _AtkTimer = false;
            if(R)
            {
                var obj = Instantiate(gameobj,new Vector3(transform.position.x+0.25f,transform.position.y,transform.position.y),Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector3(1000, 0, 0));
                StartCoroutine(AtkTimer(obj));

            }else
            {
                var obj = Instantiate(gameobj, new Vector3(transform.position.x - 0.25f, transform.position.y, transform.position.y), Quaternion.identity);
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector3(-1000, 0, 0));
                StartCoroutine(AtkTimer(obj));
            }
        }
    }
 IEnumerator AtkTimer(GameObject obj)
    {
        yield return new WaitForSeconds(0.2f);
        _AtkTimer = true;
        yield return new WaitForSeconds(1);
        Destroy(obj);

    }
}
