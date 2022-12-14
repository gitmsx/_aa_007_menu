
using System;
using System.IO;
using UnityEngine;


public class JsonReader3  : MonoBehaviour
{

  //  public static JsonReader instance;
    public SceneList MyemployeeList = new SceneList();



    public void list11(string jsonFile)
    {

        // string [] Text2Parsing = File.ReadAllLines(jsonFile);
        string textTMp = File.ReadAllText(jsonFile);
        MyemployeeList = JsonUtility.FromJson<SceneList>(textTMp);
  

    }


    [System.Serializable]
    public class Scene
    {
        public string Button1;
        public string Button2;
        public string Button3;
        public string Button4;

        public string Click1;
        public string Click2;
        public string Click3;
        public string Click4;

        public string Points1;
        public string Points2;
        public string Points3;
        public string Points4;
        

    }

    public class SceneList
    {
        public Scene[] scenes;

    }
}





