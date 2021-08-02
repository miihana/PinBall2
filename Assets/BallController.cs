using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //�{�[����������\���̂���z���̍ő�l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    //�X�R�A���Z�p
    int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
  
        
    }

    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        //�f�o�b�N�\���p
        Debug.Log("�Փ�" + other.gameObject.tag);

        // �^�O�ɂ���ăX�R�A��ς���
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 15;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 30;
        }

        //ScoreText�ɃX�R�A��\��
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }
}
