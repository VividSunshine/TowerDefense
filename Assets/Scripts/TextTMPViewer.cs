using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using UnityEngine;

public class TextTMPViewer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textPlayerHP;       // Text = TextMeshPro UI �÷��̾��� ü��
    [SerializeField]
    private TextMeshProUGUI textPlayerGold;       // Text = TextMeshPro UI �÷��̾��� ���
    [SerializeField]
    private PlayerHP playerHP;                  // �÷��̾��� ü�� ����
    [SerializeField]
    private PlayerGold playerGold;                  // �÷��̾��� ��� ����

    private void Update()
    {
        textPlayerHP.text = playerHP.CurrentHP + "/" + playerHP.MaxHP;
        textPlayerGold.text = playerGold.CurrentGold.ToString();
    }
}