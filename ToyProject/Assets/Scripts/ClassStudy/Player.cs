using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Player : MonoBehaviour
    {
        //게임이 시작이 된 후 한번만 실행된다.
        // Start is called before the first frame update

        public int gauge = 0;
        public float JumpPower= 250f;
        public float MoveSpeedModifer = 3f;
        public bool isGrounded;
        public LayerMask ground;


        void Start()
        {
            Debug.Log("저는 플레이어 입니다");

            //플레이어의 위치 z : 40으로 이동한다.
            //너의 Transform의 Position을 z를 40으로 바꿔라
            //1.위치를 이동
            transform.position = new Vector3(20, 21, 20);

            //2.회전
            transform.Rotate(new Vector3(0, 0, 0));
            //3.크기변경
            transform.localScale = new Vector3(1, 1, 1);

        }

        //반복되는 로직을 처리할 수 있다.
        //frame : 1초에 60frame FPS : frame per second
        //1frame을 생성할때 update가 한번 실행된다.
        // Update is called once per frame
        void Update()
        {
            //플레이어의 입력을 구현해보자.
            //키보드 입력.

            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("D키를 입력했습니다.");//앞으로 움직인다.             
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("D키를 땟습니다");
                gauge = 0;
            }

            if(Input.GetKey(KeyCode.D))
            {
                Debug.Log("D키를 누르고 있습니다.");
                gauge = gauge + 1;

                Debug.Log($"현재 게이지 : {gauge} ");

                transform.Translate(new Vector3(0, 0, MoveSpeedModifer) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("D키를 누르고 있습니다.");
                gauge = gauge + 1;

                Debug.Log($"현재 게이지 : {gauge} ");

                transform.Translate(new Vector3(0, 0, -MoveSpeedModifer) * Time.deltaTime);
            }

            if (Input.GetKeyDown (KeyCode.W) & isGrounded)
            {
                transform.Translate(new Vector3(0, JumpPower, 1) * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("점프를 했습니다.");

                transform.Translate(new Vector3(0, 5, 1) * Time.deltaTime);
            }
            //마우스 입력

            if(Input.GetMouseButtonDown(0))
            {
                Debug.Log("마우스 왼쪽 클릭을 했습니다");
            }

            //중력
            //transform.Translate(new Vector3(0, -9.8f, 0) * Time.deltaTime);
            
            






        }
    }
}
