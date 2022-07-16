using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rigid2D;
    Animator animator;
    public float jumpForce = 680.0f;
    public float walkForce = 30.0f;
    public float maxWalkSpeed = 2.0f;
    
    void Start() {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    void Update() {
        // 점프
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0) {  // Y 방향의 속도가 0일 때(정지 중일 때)만 점프
            this.animator.SetTrigger("JumpTrigger");    // 트리거에 의해 점프 애니메이션이 재생됨
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // 좌우 이동을 위한 방향 값 저장
        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
            key = -1;

        if (Input.GetKey(KeyCode.RightArrow))
            key = 1;

        // 현재 플레이어 속도 계산
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // 좌우 이동(스피드 제한)
        if (speedx < this.maxWalkSpeed) {                                   // 최고 속도 미만이면
            this.rigid2D.AddForce(transform.right * key * this.walkForce);  // 입력한 방향으로 힘을 준다
        }

        // 움직이는 방향에 따라 이미지 반전
        if (key != 0) {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // 플레이어의 속도에 따라 애니메이션 속도 적용
        if (this.rigid2D.velocity.y == 0)
            this.animator.speed = speedx / 2.0f;
        else
            this.animator.speed = 1.0f;

        // 플레이어가 화면 밖으로 이탈하면 처음 위치로
        if (transform.position.y < -7)
            SceneManager.LoadScene("GameScene");
    }

    // 플레이어가 깃발에 닿았을 때 호출되는 함수
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Clear!");
        SceneManager.LoadScene("ClearScene");
    }
}
