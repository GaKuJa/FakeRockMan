using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{

    [SerializeField, Header("スポーンする位置")]
    private GameObject _pos;

    [SerializeField,Header("プレイヤー")]
    private GameObject _gameObject;

    private bool Spawnflag = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            _gameObject.SetActive(false);
            Spawnflag = true;
        }

        if (Spawnflag == true)
        {
            if (Input.GetKey(KeyCode.R))
            {
                _gameObject.SetActive(true);
                _gameObject.transform.position = Vector2.MoveTowards(_pos.transform.position, _pos.transform.position, 0);
            }
        }

    }
}
