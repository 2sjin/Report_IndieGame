using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    void Update() {
        // 키보드의 [Left] 키를 눌렀을 때 왼쪽으로 이동
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-0.03f, 0, 0);

        // 키보드의 [Right] 키를 눌렀을 때 오른쪽으로 이동
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(0.03f, 0, 0);
    }

    // 버튼 LButton을 눌렀을 때 왼쪽으로 이동
    public void LButtonDown() {
        transform.Translate(-1.5f, 0, 0);
    }

    // 버튼 RButton을 눌렀을 때 오른쪽으로 이동
    public void RButtonDown() {
        transform.Translate(1.5f, 0, 0);
    }

}