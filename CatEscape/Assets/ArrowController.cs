using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrowController : MonoBehaviour {
    GameObject player;

    void Start() {
        // 플레이어 오브젝트 가져옴
        this.player = GameObject.Find("player");
    }

    void Update() {
        // 화살을 아래로 이동시킴
        transform.Translate(0, -0.02f, 0);

        // 화살이 바닥에 도달하면 제거
        if (transform.position.y < -5.0f)
            Destroy(gameObject);

        // 화살과 플레이어 충돌 여부 확인(두 원 사이의 거리 활용)
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        // 화살이 플레이어와 충돌 시
        if (d < r1 + r2) {
            GameObject director = GameObject.Find("GameDirector");  // 게임 다이렉트 가져옴
            director.GetComponent<GameDirector>().DecreaseHp();     // HP 감소
            Destroy(gameObject);    // 화살 제거
        }
        
    }
}
