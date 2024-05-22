using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper sc;
    ASM_MN ASM;

    private void Awake()
    {
        sc = FindObjectOfType<ScoreKeeper>();
        ASM = FindObjectOfType<ASM_MN>();
       // ASM = gameObject.AddComponent < ASM_MN>();
        //scoreKeeper = scoreKeeper.Instance;
        //ASM = ASM_MN.Instance;
    }

    private void Start()
    {
        scoreText.text = "You Scored:\n" + sc.GetScore();

        //ASM_MN.Instance.YC1(ScoreKeeper);



        ASM_MN.Instance.YC1();
        ASM_MN.Instance.YC2();
       /* ASM.YC3();
        ASM.YC4();
        ASM.YC5();
        ASM.YC6();
        ASM.YC7();*/
    }

    


}
