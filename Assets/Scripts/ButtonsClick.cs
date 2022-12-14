

using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;


public class ButtonsClick : MonoBehaviour
{


    [SerializeField]  TextMeshProUGUI[] TextButton = new TextMeshProUGUI[4];
    [SerializeField]  Button[] ButtonS = new Button[4];






    void Start()
    {






        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        ButtonS[0].onClick.AddListener(TaskOnClick0);
        ButtonS[1].onClick.AddListener(TaskOnClick1);
        ButtonS[2].onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        ButtonS[3].onClick.AddListener(() => ButtonClicked(42));

    }




    void TaskOnClick1()
    {
        list11();    
    }


    void TaskOnClick0( )
    {
        list12();
    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
        

    }


    public TextAsset jsonFile;
    public SceneList MyemployeeList = new SceneList();

    public void list11()
    {
        MyemployeeList = JsonUtility.FromJson<SceneList>(jsonFile.text);
        int ii = 0;
        foreach (Scene e in SceneList.scenes)
        {

            TextButton[0].text = e.Button0;
            TextButton[1].text = e.Button1;
            TextButton[2].text = e.Button2;
            TextButton[3].text = e.Button3;

            ii++;
        }
    }



    [System.Serializable]
    public class Scene
    {
        public string Button1;
        public string Button2;
        public string Button3;
        public string Button0;

        public string Click1;
        public string Click2;
        public string Click3;
        public string Click0;

        public string Points1;
        public string Points2;
        public string Points3;
        public string Points0;


    }

    public class SceneList
    {
        public Scene[] scenes;

    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);

        string path = "Assets/Resources/s001e001.json";
        if (FileExists(path))
        {
            JsonReader3 jsonReader3 = new JsonReader3();
            jsonReader3.list11(path);

        }




    }


    bool FileExists(string FileName)
    {


        if (FileName == null || FileName.Length == 0)
            return false;
        FileInfo fInfo = new FileInfo(FileName);

        if (!fInfo.Exists)
            return false;
        return true;


    }
}



