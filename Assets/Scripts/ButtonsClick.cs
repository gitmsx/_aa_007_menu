

using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;


public class ButtonsClick : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    [SerializeField] private Button Button0, Button1, Button2, Button3;
    [SerializeField] TextMeshProUGUI TextButton0, TextButton1, TextButton2, TextButton3;








    void Start()
    {

        TextMeshProUGUI[] TextButton = new TextMeshProUGUI[14];
    Button[] ButtonS = new Button[14];


    TextButton[0] = TextButton0;
        TextButton[1] = TextButton1;
        TextButton[2] = TextButton2;
        TextButton[3] = TextButton3;

        ButtonS[0] = Button0;
        ButtonS[1] = Button1;
        ButtonS[2] = Button2;
        ButtonS[3] = Button3;


        print(TextButton[1].text);
        print(TextButton[2].text);
        print(TextButton[3].text);
        print(TextButton[0].text);
        print("TextButton[3]");


        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        Button0.onClick.AddListener(TaskOnClick0);
        Button1.onClick.AddListener(TaskOnClick1);
        Button2.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        Button3.onClick.AddListener(() => ButtonClicked(42));

    }




    void TaskOnClick1()
    {
    
    }


    void TaskOnClick0( )
    {
       
    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
        

    }


    public TextAsset jsonFile;
    public EmployeeList MyemployeeList = new EmployeeList();

    public void list11(TextMeshProUGUI[] TextButton)
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
    public void list12(TextMeshProUGUI[] TextButton)
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



