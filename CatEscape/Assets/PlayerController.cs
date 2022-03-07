using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    void Start() { }

    void Update() {
        // Left 키를 눌렀을 때 왼쪽으로 이동
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-0.03f, 0, 0);

        // Right 키를 눌렀을 때 오른쪽으로 이동
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(0.03f, 0, 0);
    }

    public void LButtonDown() {
        transform.Translate(-1.5f, 0, 0);
    }

    public void RButtonDown() {
        transform.Translate(1.5f, 0, 0);
    }

}