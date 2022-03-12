using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {
    float rotSpeed = 0;     // 룰렛의 회전 속도

    void Start() { }

    void Update() {
        if (Input.GetMouseButtonDown(0))    // 마우스를 눌렀을 때
            this.rotSpeed = 5;              // 회전 속도 증가
        transform.Rotate(0, 0, this.rotSpeed);  // 회전 속도만큼 룰렛 회전
        rotSpeed *= 0.995f;    // 회전 속도 서서히 감소
    }

}
