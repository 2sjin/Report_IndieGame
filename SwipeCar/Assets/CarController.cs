using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
    float speed = 0;
    Vector2 startPos, endPos;

    void Start() { }

    void Update() {
        if (Input.GetMouseButtonDown(0))    // 마우스 버튼을 누를 때
            startPos = Input.mousePosition; // 현재 마우스 좌표를 startPos 벡터에 저장

        else if (Input.GetMouseButtonUp(0)) {   // 마우스 버튼을 뗄 때
            endPos = Input.mousePosition;   // 현재 마우스 좌표를 endPos 벡터에 저장

            float swipeLength = endPos.x - startPos.x;  // 마우스로 스와이프한 길이 계산
            this.speed = swipeLength / 5000.0f; // 스와이프 길이 보정

            GetComponent<AudioSource>().Play(); // 오디오 소스 재생
        }

        transform.Translate(this.speed, 0, 0);  // X 방향으로 자동차 이동
        this.speed *= 0.98f;
    }

}
