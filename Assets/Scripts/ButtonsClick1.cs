

using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;


public class ButtonsClick1 : MonoBehaviour
{


    [SerializeField]  TextMeshProUGUI[] TextButton = new TextMeshProUGUI[4];
    [SerializeField]  Button[] ButtonS = new Button[4];






    void Start()
    {
      
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
    public EmployeeList MyemployeeList = new EmployeeList();

    public void list11()
    {
        MyemployeeList = JsonUtility.FromJson<EmployeeList>(jsonFile.text);
        int ii = 0;
        foreach (Employee e in MyemployeeList.employees)
        {

            if (ii < 4)
            {
                TextButton[ii].text = " firstName =" + e.firstName + " lastName " + e.lastName + " Age " + e.age.ToString();
            }

            ii++;
        }
    }
    public void list12()
    {
        MyemployeeList = JsonUtility.FromJson<EmployeeList>(jsonFile.text);
        int ii = 0;
        foreach (Employee e in MyemployeeList.employees)
        {

            if (ii < 4)
            {
                TextButton[ii].text = " 100 firstName =" + e.firstName + " lastName " + e.lastName + " Age " + e.age.ToString();
            }

            ii++;
        }
    }


    [System.Serializable]
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int age;

    }

    public class EmployeeList
    {
        public Employee[] employees;

    }


    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);

        string path = "Assets/Resources/Employees.json";
        if (FileExists(path))
        {
            JsonReader2 jsonReader2 = new JsonReader2();
            jsonReader2.list11(path);

        }


        foreach (Employee e in MyemployeeList.employees)
        {
            Debug.Log(e.lastName);
            Debug.Log(e);
            Debug.Log(e.age);
            Debug.Log(e.firstName);
            Debug.Log("************ 77777777777777777777777777 ********");


        }






    }


    bool FileExists(string FileName)
    {


        if (FileName == null || FileName.Length == 0)
            return false;
        //{
        //    throw new ArgumentNullException("FileName");
        //}

        // Check to see if the file exists.
        FileInfo fInfo = new FileInfo(FileName);

        // You can throw a personalized exception if
        // the file does not exist.
        if (!fInfo.Exists)
            return false;

        //{
        //    throw new FileNotFoundException("The file was not found.", FileName);
        //}
        return true;


    }
}



