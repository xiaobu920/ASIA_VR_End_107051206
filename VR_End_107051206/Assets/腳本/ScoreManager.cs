using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("預設得分")]
    public int scoreP = 1;
    [Header("得分音效")]
    public AudioClip soundIn;   //存音效

    private AudioSource aud;    //存元件

    private void Awake()
    {   
        //音效來源=取得元件<音效來源>()
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "可丟物")
        {
            AddScore();
        }
        if (other.transform.root.name == "Player")
        {
            scoreP = 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            scoreP = 1;
        }
    }

    void AddScore()
    {
        score += scoreP;
        textScore.text = "加料分數：" + score;
        aud.PlayOneShot(soundIn, Random.Range(0.5f,2f));
    }

}
