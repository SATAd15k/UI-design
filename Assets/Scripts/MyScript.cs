/*
C# has specific syntax rules you must follow
    End lines with a ;
    Enclosing conditions with ()
    Group statements with {}
    Case Sensitive (C =/= c)

Bundles of prewritten code
Keyword using tells our script to include a prewritten set of code (library)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Import UI Library

/*
This is a class
    A collection of variables and methods aka functions
    They are a blueprint of behaviors
    Classes can inherit variables and methods from each other allowing modular code (polymorphism)

: means inherit / indicates inheritance (from left to right)

MonoBehavior is the base class for all scripts we want to attach to game objects
*/
public class MyScript : MonoBehaviour
{
    /*
    A variable is a container to store data in which we can compare, change and copy
    We have to declare a variable before we can use it

        Public / Private is wether the variable can be seen from another script

        Data Type is what kind of data the variable will hold
        The data type below is an integer (a whole number; no decimals)
    */

    public int MyInt; //Integer
    public float MyFloat; //Number with decimal
    public string MyString; //Collection of Characters
    public char MyChar; //Single character
    [SerializeField] private int HiddenInt; // Lets only us as the designer see this; not other scripts
    public Text ScoreText;

    /*
    Methods let you manipulate variables
    You can call methods (run them) from inside other methods
    In C# you can define methods in any order
    */
    public void MyMeth()
    {
        MyInt++; //Add 1 to int
        /*
        MyInt--; //Minus 1 from int
        MyInt = MyInt + 2; //Changing value on left to = on the right
        MyInt += 1; //Performs equation and shows equal directly
        */
    }
    //Button can access scripts atached to public game objects
    private void Start()
    {
        //Can call methods inside others
        MyMeth();
    }

    private void Update()
    {
        ScoreText.text = " Score: " + MyInt.ToString();
    }
}
