using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Player : MonoBehaviour
    {
        //������ ������ �� �� �ѹ��� ����ȴ�.
        // Start is called before the first frame update

        public int gauge = 0;
        public float JumpPower= 250f;
        public float MoveSpeedModifer = 3f;
        public bool isGrounded;
        public LayerMask ground;


        void Start()
        {
            Debug.Log("���� �÷��̾� �Դϴ�");

            //�÷��̾��� ��ġ z : 40���� �̵��Ѵ�.
            //���� Transform�� Position�� z�� 40���� �ٲ��
            //1.��ġ�� �̵�
            transform.position = new Vector3(20, 21, 20);

            //2.ȸ��
            transform.Rotate(new Vector3(0, 0, 0));
            //3.ũ�⺯��
            transform.localScale = new Vector3(1, 1, 1);

        }

        //�ݺ��Ǵ� ������ ó���� �� �ִ�.
        //frame : 1�ʿ� 60frame FPS : frame per second
        //1frame�� �����Ҷ� update�� �ѹ� ����ȴ�.
        // Update is called once per frame
        void Update()
        {
            //�÷��̾��� �Է��� �����غ���.
            //Ű���� �Է�.

            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("DŰ�� �Է��߽��ϴ�.");//������ �����δ�.             
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("DŰ�� �����ϴ�");
                gauge = 0;
            }

            if(Input.GetKey(KeyCode.D))
            {
                Debug.Log("DŰ�� ������ �ֽ��ϴ�.");
                gauge = gauge + 1;

                Debug.Log($"���� ������ : {gauge} ");

                transform.Translate(new Vector3(0, 0, MoveSpeedModifer) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("DŰ�� ������ �ֽ��ϴ�.");
                gauge = gauge + 1;

                Debug.Log($"���� ������ : {gauge} ");

                transform.Translate(new Vector3(0, 0, -MoveSpeedModifer) * Time.deltaTime);
            }

            if (Input.GetKeyDown (KeyCode.W) & isGrounded)
            {
                transform.Translate(new Vector3(0, JumpPower, 1) * Time.deltaTime);

            }

            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("������ �߽��ϴ�.");

                transform.Translate(new Vector3(0, 5, 1) * Time.deltaTime);
            }
            //���콺 �Է�

            if(Input.GetMouseButtonDown(0))
            {
                Debug.Log("���콺 ���� Ŭ���� �߽��ϴ�");
            }

            //�߷�
            //transform.Translate(new Vector3(0, -9.8f, 0) * Time.deltaTime);
            
            






        }
    }
}
