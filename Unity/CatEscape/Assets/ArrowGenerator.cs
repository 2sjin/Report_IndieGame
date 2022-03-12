using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {
    public GameObject arrowPrefab;
    float span = 0.3f;  // 화살 생성 시간 간격(초)
    float delta = 0;    // 누적 시간

    void Update() {
        this.delta += Time.deltaTime;   // 누적 시간 가산
        if (this.delta > this.span) {

            // 누적 시간 초기화
            this.delta = 0;

            // 새 화살 생성
            GameObject go = Instantiate(arrowPrefab) as GameObject;

            // 랜덤한 X 좌표로 화살 이동
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }

}
