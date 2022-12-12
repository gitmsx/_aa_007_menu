using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class TextTmpOutTerminal103: MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textOut;

    private Coroutine CourutineWork;
    public float SpeedText = 0.01f;
    public float SpeedText2 = 0.09f;



    int QueueAllStrings = 0;
    int CurrentElementQueueAllStrings = 0;


    [SerializeField] string[] str = new string[7];
    [SerializeField] string[] strTM = new string[7];

    private void OnValidate()
    {
        textOut.text = "";
        textOut.text += "���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "2���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "3���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "4���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "5���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
        textOut.text += "6���������� � ����������� �����.-�������� ��� ������ ������� � ��� ����������� ������� ����������, � ������� �������� ������������ ����� ���������� ��������, ��������� ���������, ������ �������������. � ��������� ������� ������������ ����� ����� �������� ����� �� ��������, ����� �������� ���������.";
    }

    // Start is called before the first frame update
    void Start()
    {
        textOut.text = "";











        str[0] = "Computer1<#800000>23science is the study12<#FFFF00>34 of computation,1123<#0000FF>45678 automation, and information.[1]<";
        str[1] = "\n������ <#FFFF00> ������������ ����� <#800000>���������� ������ i <#FF00FF>and Computer <#7FFF00>science spans theoretical disciplines (such as algorithms, theory of computation, ";
        str[2] = "\n��, 1<#00FF00>2��� ������ ������ ����������3<#FF00FF>4 � ��������, � ����� ������ �������� ��, �� �� �������� ����� �����";
        str[3] = "\n�������� <#FFD700>����������� ������<#FFFF00> ������ ����� � 1936 - �� �� 1949<#F4A460> ���.� ���� ������ � ���� ���� ��������� ������������,";
        str[4] = "\n�������� � <#00008B>�� ��� ����������, � ��� ����������� �������� <#00FFFF>� �������� ������������� � <#C0C0C0>������� ��������� ����.";
        str[5] = "\n� ��� ��� ��� ������ ��� ����� ���������� ������ ��� ��������� �������, ��� ��������� ������; � ��� ������� ����� �������� ���� ��������� ";

        CourutineWork = null;
        QueueAllStrings = str.Length;
        CurrentElementQueueAllStrings = 0;
        for (int i = 0; i < QueueAllStrings; i++)
            CourutineWork = StartCoroutine(printtext22(i, str[i]));


        // CourutineWork = StartCoroutine(printline());



        // StartCoroutine(printline());


    }


    IEnumerator printtext(int i, string strT)
    {
        while (CourutineWork != null)
            yield return new WaitForSeconds(0.2f);
        foreach (char c in strT)
        {
            textOut.text += c;
            yield return new WaitForSeconds(SpeedText);
        }
        CourutineWork = null;
        yield break;
    }



    IEnumerator printtext22(int i, string strT)
    {


        while (CurrentElementQueueAllStrings != i)
            yield return new WaitForSeconds(0.2f);
        
        //while (CourutineWork != null)
        //    yield return new WaitForSeconds(0.2f);
        char c;

        for (int j = 0; j < strT.Length; j++)
        {
            c = strT[j];

            if ((strT[j] == '<') && (j + 1 < strT.Length) && strT[j + 1] == '#')
            {
                for (int k = j; k < j + 10; k++)
                    textOut.text += strT[k];
                j += 9;
            }
            else
            {
                textOut.text += c;
                yield return new WaitForSeconds(SpeedText);
            }
        }
        CourutineWork = null;
        CurrentElementQueueAllStrings ++;
        yield break;
    }



    IEnumerator printline()
    {
        while (CourutineWork != null)
            yield return new WaitForSeconds(0.2f);
        for (int i = 1; i < str.Length; i++)
        {
            textOut.text += str[i];
            yield return new WaitForSeconds(SpeedText2);
        }

    }


}
