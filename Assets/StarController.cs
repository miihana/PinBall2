using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    // ��]���x
    private float rotSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //��]���J�n����p�x��ݒ� 0����359�̐����������_���ɕԂ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);


    }

    // Update is called once per frame
    void Update()
    {
        //��] ��]���x�Ɖ�]������������߂� Y���𒆐S�Ƃ��Đ�����]
        this.transform.Rotate(0, this.rotSpeed, 0);


    }
}
