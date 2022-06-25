using System;
using namespace std;
public class Ifexample{
      

      public static void Main(string[]args){




                  int num = 10;
                  if(num%2==0){


                         Console.WriteLine("Nos is even ");
                  } 

                  else {


                     Console.WriteLine("Nos is Odd");
                  }   


      }



}
public class Ifelsexample{
      

      public static void Main(string[]args){




            Console.WriteLine("Enter the numbers");
            int num = Console.Int32("Console.ReadLine");

            if(num%2==0){


               Console.WriteLine("Nos is Even");

            }
            else {


             Console.WriteLine("Nos is Odd");
            }
      }


}
public class IfelseifladderExample{
      


      public static void main(string[]args){



              Console.WriteLine("Enter the numbers to check the grade");
              int grade = console.Int32(Console.ReadLine());



               if(grade<0||grade>100){

                 console.WriteLine("Wrong Number You have  Entered");
               }
               elseif(grade>=0  &&  grade<35){

                  Console.WriteLine("You are failed");

               }
               elseif(grade>=35  &&  grade<50){

                  Console.WriteLine("D Grade");

               }
               elseif(grade>=50 && grade<60){

                  Console.WriteLine("C Grade");
               }
               elseif(grade>=60 && grade<70){

                  Console.WriteLine(" B Grade");
               }
               elseif(grade>=70 && grade<90){

                  Console.WriteLine("A Grade");
               }
               elseif(grade>=90 && grade<100){

                   Console.WriteLine("A+ Grade");
               }








      }
}

public class SwitchExample{
      

      public static void Main(string[]args){


           Console.WriteLine("Enter the numbers ");
           int num = Console.Int32(Console.ReadLine());

           switch(num){


               case 10:
                Console.WriteLine("Nos is 10");
                break;
               case 20:
                 Console.WriteLine("Nos is 20");
                 break;
               case 30:
                  Console.WriteLine("Nos is 30");
                  break;
               Default :
                  Console.WriteLine("Nos is not 10 , nor 20 , nor 30");
                  break;






           }
      }
}

public class ForExample{
      

      public static void Main(string[]args){


           for(int i = 1 ; i<=10 ; i++){


              Console.WriteLine(i);
           }
      }
}

public class twoForExamples{
      

      public static void Main(string[]args){


          for(int i = 1; i<=3;i++){

             for(int j = 1; j <=3 ; j++){

                   Console.WriteLine(i+""+j);
             }
          }
      }
}

public class InfiniteForloopExample{
      


      public static void Main(string[]args){
 


            for(;;){

                Console.WriteLine("Infinite For Loop");
            }
      }
}


namespace FunctionExample(){
      


      class program(){


             public void Show(){


                Console.WriteLine("This is non-Parmeterised Function");
             }


             public static void Main(string[]args){



                  program Pro = new program(); //Creating the object;

                 Pro.Show();//Calling the object;


            }



      }
}

namespace  FunctionParameterExample(){


            class Parameter(){



               public void   Paramter_function(string message){


                        Console.WriteLine("Hello"  + message)



                 }

                 public static void Main(string[]args){



                          Parameter prm = new Parameter();
                          prm.Paremeter_function("Hitesh");//Parametrized Function
                 }
            }
      
}
namespace std{
      



    class Program(){



       public string Parfunction(string Message){


         Console.WriteLine("hello This is Parameterised with return type function"+Message);
       }

       public static void Main(string[]args){


       Static Parameter = new Parfunction("YoiiBoii");
       Console.WriteLine(Parameter);
       }
    }

}


namespace CallbyValue{
      

      class Program(){



          public void show(int val){




             val* = val; //Manipulating the value
             Console.WriteLine("Value inside the function" +val);


          }

          public static void Main(string[]args){



             int val = 50;
             Program program = new Program();
             Console.WriteLine("Value calling before the function"+val);
             program.show(val);
             Console.WriteLine("Value calling after the function"+val);


         }
     }
}

namespace  CallByreference
{
      

      class callByReference{


          public void Show(ref int val){




              val* =  val;
              Console.WriteLine("Value inside the function"+val);


          }

          public static void Main(string[]args){



             int val = 80;
             Console.WriteLine("Value  before calling the function"+val);
             callByReference cbr = new CallByReference();
             cbr.Show(ref int val);
             Console.WriteLine("Value  after calling the function"+val);

          }
      }
}

namespace OutParameter{
      



      public class outparameter{


             public void info(out int val){


                int Square = 5;
                val = Square;
                val* = val;



             }

             public static void Main(string[]args){


                int val = 50;
                Console.WriteLine("Value Before Calling the out Variable"+val);
                outparameter outp = new outparameter();
                outp.info(out val);
                Console.WriteLine("Value After Calling the out variable" + val);


             
             }


       }


}

namespace OutParameter2{
      



      public class Outparameter2{


          public void outinfo(out int a , out int b){


               int square = 9;
               a = square;
               b = square;

               a* = a;
               b* = b;


          }
          public static void Main(string[]args){

              int val1 = 20;
              int val2 = 45;

              PutParameter2 outp2 = new OutParameter2();
              Console.WriteLine("Value Before passing \nval1 = "+val1+"\nval2="+val2);
              outp2.outinfo(out val1 , outval2);
              Console.WriteLine("Value After Passing \n val1 ="+val1+"\n val2 = "+val2);

          }
      }
}

namespace SingleDimensionArray{
      


      public class Array{



          int [] arr = new int[5];//Creating the array of length 5
          arr[0] = 10;
          arr[1] = 20;
          arr[2] = 30;
          arr[3] = 40;
          arr[4] = 50;

          public void show(){



             for(int i = 0; i<arr.length;i++){

                 Console.WriteLine(arr[i]);
             }
          }

          public static void Main(string[]args){

              Array array = new Array();
              a = array.show();
              Console.WriteLine(a);



          }

      }

}
namespace std{
      

      public class Arrayiniliazation{



            char [] ch = {'H' ,'I' ,'T' ,'E', 'S' ,'H'}; /*Decalarationa and Initialiazation of an Array without Specifying the limit and length */



            public void Info(){

                          

                          for(int i = 0;i<ch.length;i++){

                             Console.WriteLine(ch[i]);
                          }
  

            }


            public static void Main(string[] args){

                Arrayiniliazation arrayini = new Arrayiniliazation();
                arr = arrayini.Info();
                Console.WriteLine(arr);


            }

      }
}

namespace ArrayTraversal{
      

      public class Traversal{


          public void Showinfo(){



             int [] array = {1,2,3,4,5,6,7,8,9};

             foreach(int i in array){ 

             //Traversal USing foreach loop;

                Console.WriteLine(i);
             }


             public static void Main(string[]args){

                 Traversal traversal = new Traversal();
                 traversal.Showinfo();

             }
          }
      }
}
public class ArrayByFunction{
      


      static void PrintArray(int[]arr){


          for(int i = 0; i<=arr.Length;i++){

            Console.WriteLine("Printing Array Elements \n");



             Console.WriteLine(i);


          }

          public stativ void Main(string[]args){



              int[] arr1 = {1,5,6,4,7,9};
              int[] arr2 = {4,45,85,65,78,45};


              Console.WriteLine("Arrray by Function is \n");
              PrintArray(arr1);
              PrintArray(arr2);


          }
      }
}

namespace std{
      


      public static void Printmin(){


              int min = arr[0];
              for(int i = 0;i<arr.Length;i++){


                  if(min>arr[i]){

                    min = arr[i];

                  }
              }
              Console.WriteLine("Minimum Element is "+min);


      }

      public static void Main(string[]args){


          int []arr1 = {45,64,48,75,65};
          int[]arr2 = {45,68,98,47,56};

          Printmin(arr1);
          Printmin(arr2);

      }
}
 namespace Array{


    public static void Main(string[]args){


            static void PrintMax(int [] arr){


              int [] max = arr[0];

              for(int i = 0;i<arr.Length;i++){

                 if(max<arr[i]){

                 max = arr[i];
                 }
              }
              Console.WriteLine("Maximum Elements is :");
            }

            public static void Main(string[]args){

                  int[]arr1 = {45,65,89,45,42,65,48};
                  int[]arr2 = {47,85,698,5,8,2,6,4,6};

                  PrintMax(arr1);
                  PrintMax(arr2);
                  
            }
    }
 }

public class MultidimensionaltwoDArrayExample{
      



      public static void Main(string[]args){



         int [,] array = new int[3,3];

         array[0,1] = 20;
         array[1,2] = 30;
         array[2,2] = 40;

         for(int i = 0;i<3;i++){

            for(int j = 0; j<3;j++){


                  console.WriteLine(array[i,j]+"");

            }

            Console.WriteLine();
         }


      }
}

public class MultidimensionalthreeDArrayExample{
      
            
            public void ThreeDExample(){



                  int [,] array = {{1,2,3},{4,5,6},{7,8,9}};

                  for(int i = 0;i<3;i++){

                        for(int j = 0; j<3;j++){

                              Console.WriteLine(array[i,j]+"");

                        }

                        Console.WriteLine();

                  }
                  
            }

}
namespace JaggedArrays{
      


      public class Jaggedarrays{


            public static void Main(string [] args){



                  int[][] arr = new int[2][];

                  arr[0] = {10,45,68,98,78};
                  arr[1] = {15,658,48,65,89,25};


                  for(int i = 0; i<arr.Length;i++){

                        for(int j = 0 ; j<arr[i].Length;j++){

                                     Console.WriteLine([i][j]+"");

                        }

                        Console.WriteLine();
                  }



            }
      }
}

namespace JaggedArrayssecondExample{
      


        public class SecondArrayJaggedExample{


               public static void main(string[]args){


                        int[][] array = new int[3][]{

                              new int[] = {1,2,3,4,5,6};
                              new int[] = {7,,8,9,6,2,4};
                              new int[] = {4,56,8,6,52,85,65};

                        }

                        for(int i = 0;i<array.Length;i++){

                               for(int j = 0;j<array[i].Length;i++){


                                    Console.WriteLine([i][j]+"");

                               }

                               Console.WriteLine();

                        }



               }
        }
}


namespace AccessSpecifier{
      

      public class Params{


             public static void Show(params int [] val){


                   for(int i = 0; i<val.Length;i++){

                                    Console.WriteLine(val[i]);

                   }

                   public static voiid Main(string[]args){



                        Params paramkeyword = new Params();

                         givenParam = paramkeyword.Show(1,2,3,4,5,6,789,9);

                         Console.WriteLine(givenParam);



                   }

             }
      }
}


namespace AcessSpecifier {
      


      public class Program{


          public static void Info(params object [] items){

                  for(int i = 0;i<items.Length;i++){
                         Console.WriteLine(items[i]);

                  }

                  public static void Main(string[]args){

                        Program paramsobject = new Program();
                        paramsobject.Info("Hitesh " ,"Asjad" ,8865 , 8801 , 0.11 , "Arisha Dude");


                  }
          }
      }
}


namespace AccessSpecifier{
      

      public class Program{

            int[] arr = new int[6] {1,236,56,78,58,89};
            int[] arr2 = new int[6];

            Console.WriteLine("The length of the Array is "+arr.Length);
            Array.Sort(arr);
            Console.WriteLine("Fisrt Array Elements:");
            PrintArray(arr);
            Console.WriteLine("Indexed Position of 56 is :"+Array.indexOf(arr,56));
            Console.WriteLine("Second Array Elements is :"+Array.copy(arr, arr2 , arr2.Length));
            PrintArray(arr);
            Array.Reverse(arr);
            Console.WriteLine("\n First Array Elements in reverse order :");
            PrintArray(arr);



      }

      public static void PrintArray(int[]arr){


            foreach(Object element in arr){

                  Console.WriteLine(element +"");

            }
      }

}



namespace std{
      

      public class Objects{

            int id;
            string name;

            public static void Main(string[]args){


                  Objects obj = new Objects();
                  obj.id = 8865;
                  obj.name = "Hitesh Jha";


                  Console.WriteLine("The id of the students is "+obj.id);
                  Console.WriteLine("The name of the student is "+obj.name);
                  
            }
      }

}
namespace  std{
      

      public class Employe{

             public int id;
             public  string name;
             public float salary;
             public string Address;


            public void  insert(int ID , string NAME ,float SALARY , string ADDRESS){

                  id = ID;
                  name = NAME;
                  salary = SALARY;
                  Address = ADDRESS;


            }

            public void Display(){
                  Console.WriteLine(id+""+name+""+salary+""+Address);

            }

      }

      class TestStudent{


            public static void Main(string[]args){

                  Employe E1 = new Employe();
                  Emplopye E2 = new Employe();

                  E1.insert(8865 , "Hitesh Jha" , 2000000 , "Ganeshanagar , Bopkhel , Pune City");
                  E2.insert(8801 ,"Mohammad Asjad " , 51000000 ,  "Bombay Sappers");
                  E1.Display();
                  E2.Display();


            }
      }
}



namespace Constructor{
      

      public class Student{

            public Student(){

                  Console.WriteLine("Default Constructor is Invoked here");
            }

            public static void Main(string[]args){

                  Student s1 = new Student();
                  Student s2 = new Student();


            }
      }
}
namespace Constructorwithanotherclass{
      

      public class Constructor(){

            public Constructor{

                  Console.WriteLine("Default Constructor is Invoked");

            }

      }
      public class DefaultConstructor{

            public static void Main(string[]args){

                  Constructor C1 = new Constructor();

            }
      }
}


namespace Parametrized_Constructor{
      

      public class Employee{

            public int id;
            public string name;
            public float salary;

            public Employee(int ID , string Name , float Salary){

                   id = ID;
                   name = Name;
                   salary = Salary;

            }

            public void Display(){

                  Console.WriteLine(id+""+name+""+salary);

            }


      }

      class TestParameterizedConstructor{

            Employee E1 = new Employee(8865 , "Hitesh Jha" ,200000000);
            Employee E2 = new Employee(8853, "Raji Patel" , 500000000);

            E1.Display();
            E2.Display();
            


      }
}


namespace std{


      public class Program{

            public Program(){

                  System.Console.WriteLine("Constructor is Inovked");

            }
            ~ Program(){

                  Console.WriteLine("Destructor is Invoked");

            }
      }

      public class TestProgram{

            public static void Main(string[]args){

                   Program P1 = new Program();
                   Program P2 = new Program();

                   Console.WriteLine("Destructor is created");



            }
      }
}


namespace AccessSpecifier{

      public class ThisKeyword{

            public int id;
            public string name;
            public float Salary;

            public ThisKeyword(int id , string name , float Salary){

                  this.id = id;
                  this.name = name;
                  this.Salary = Salary;




            }
            public void Show(){

                  Console.WriteLine(id+""+name+""+Salary);

            }

            
      }

      public class TestThisKeyword(){


            ThisKeyword thk = new ThisKeyWord(8865 , "Hitesh Jha" ,2200000000);
            ThisKeyword thk2 = new ThisKeyWord(8801 , "Mohammad Asjad" , 251200000);
            ThisKeyword thk3 = new ThisKeyWord(8853 , "Raji Patel" ,25456521);
            ThisKeyword thk4 = new ThisKeyWord(8840 , "Arisha Pangal" ,4454444282);
            ThisKeyword thk5 = new ThisKeyWord(8841, "Swaleha Zarekari" , 54448412165);


            thk.Show();
            thk2.Show();
            thk3.Show();
            thk4.Show();
            thk5.Show();



      }
}

namespace STatic{

      public class Static_modifier{


            public int acc_nos;
            public string name;
            public static float rateOfInterest = 8.8f;

            public Static_modifier(int acc_nos , string name){

                  this.acc_nos = acc_nos;
                  this.name = name;



            }
            public void Display(){

                  Console.WriteLine(acc_nos+""+name+""+rateOfINterest);

            }

      }
      public class Test_Static_Keyword(){

            public  Static void Main(string[] args){

                  Static_modifier sm = new Static_modifier(12544442200, "Hitesh Jha");
                  Static_modifier sm2 = new Static_modifier(4865866685,  "MOhammad Asjad");
                  Static_modifier Sm3 = new Static_modifier(4548645586 , "Raji Patel");

                  sm.Display();
                  sm2.Display();
                  sm3.Display();


            }
      }

}

namespace AccessStaticKeyword{


      public class static_keyword{

            public int Acc_nos;
            public string Acc_Name;
            public static float Acc_rateofInterest = 8.86f;

            public static_keyword( int Acc_nos , string Acc_name){

                  this.Acc_nos = Acc_nos;
                  this.Acc_Name= Acc_Name;



            }

            public Show_Info(){

                  Console.WriteLine(Acc_nos+""+Acc_Name);

            }


      }
      public class Teststatic_keyword(){


            public static void Main(string[]args){


                  static_keyword.Acc_rateofInterest = 10.36f;//Changing Values;

                  static_keyword sk = new static_keyword(88654568565 , "Hitesh Jha");
                  static_keyword sk2 = new static_keyword(4586658254, "Mohammad Asjad");

                  sk.Show_Info();
                  sk2.Show_Info();
            }
      }
}




namespace Car_features{

      public class Car_functions{

            public int Car_nos;
            public string Car_name;
            public static float Car_count = 0;


      }
      public Car_functions(int car_nos, string car_name){
            this.car_nos = car_nos;
            this.car_name = car_name;

            car_count++;





      }

      public void Display_car_info(){

            Console.WriteLine("The nos of the car is " car_nos+""+"and the name of the car is "+car_name);

      }

      public class TestCar_functions{

            public static void Main(string[]args){

                  Car_functions cf = new Car_functions(3436 ,"Range Rover");
                  cf.Display_car_info();

                  Console.WriteLine("The total nos of the Objects in the Program are :" Car_functions.Car_count);

            }
      }


}

namespace Static_Class{


      public class Static_class_members{

            public  static int Roll_nos;
            public static string Student_name;

            public static int Cubeofnos(int n){

                  return n*n*n;

            }



      }
      public class TestStaticmembers{

            public static void Main(string[]args){

                  Console.WriteLine("The Roll nos of the Students is " Static_class_members.Roll_nos);
                  Console.WriteLine("The Name of the Student is " static_class_members.Cubeofnos(10));

                  
            }
      }
}


//Static Constructor:-------->
namespace Static_Constructor{


      public class Account{

            public int Acc_id;
            public string Acc_name;
            public static float rateOfinterest;

            public Account(int Acc_nos , string Acc_name){

                  this.Acc_id = Acc_id;
                  this.Acc_name = Acc_name;

            }


            static Account(){

                  rateOfinterest = 9.5f;

            }

            public void DisplaysomeInfo(){

                  Console.WriteLine(Acc_nos+""+Acc_name+""+rateOfinterest);

            }


      }
      public class Test_Static_constructor{

            public static void Main(string[]args){

                  Account A1 = new Account(8658985655 , "Hitesh Jha");
                  Account A2 = new Account(4544544454 , "zarekari");

                  A1.DisplaysomeInfo();
                  A2.DisplaysomeInfo();

            }
      }

}


// Struct Keyword:---------->
namespace Structs{

      public struct Rectangle{

            public int lengh , breadth;

      }

      public class AreaofRecatngle{

            public static void Main(string[]args){

                  Rectangle R = new Rectangle();

                  R.length = 45;
                  R.breadth = 65;

                  Console.WriteLine("Area of the Rectangle is "+(R.Length*R.breadth));
            }
      }
}

namespace _Structs{

      public struct Car{

            public int Car_nos;
            public string Car_name;


            public Car(int car_nos , string car_name){

                  this.car_nos = car_nos;
                  this.car_name = car_name;

            }

            static Car(int c_n , string c_name){

                  car_nos = c_n;
                  car_name = c_name;


            }

            public void Display(){


                  Console.WriteLine(car_nos+""+car_name+""+);
            }

      }
      public class Test_subject{

            public static void Main(string[]args){

                  Car car = new Car(3406, "Range Rover");
                  Car car2 = new Car(8865 ,"Lambhorghini");


                  car.Display();
                  car2.Display();

            }
      }

}

//Enumeration:--------->
namespace Enumeration{


      public enum Season{Winter , Summer , Spring , Rainy , Autumn}

      public class Enum{


            public void _Display_enum(){

                  int x = (int)Season.Winter;
                  int y = (int)Season.Autumn;
                  int z = (int)Season.Summer;


                  Console.WriteLine("Winter = {0}" , x);
                  Console.WriteLine("Summer = {0}" , y);
                  Console.WriteLine("Autumn = {0}" , z);

            }
      }

      public static void Main(string[]args){

            Enum enumeration = new Enum();
            Enum enumeration2 = new enum();


            enumeration._Display_enum();
            enumeartion2._Display_enum();





      }
}


namespace Std{

      public enum Days {days1 = 45 , days2 ,days3 }
      public class Enumeration{

            public void Display(){

                  int x = (int)Days.days1;
                  int y = (int)Days.days2;

                  Console.WriteLine("Days = {0}" , x);
                  Console.WriteLine("Days = {0}" , y);


            }

      }

      public class Test_Enum{

            public static void Main(string[]args){

                  Enumeration E1 = new Enumeration();
                  E1.Dsiplay();

                  
            }
      }
}


//C# Properties:----->

namespace Properties{

    public class Student{

         private string name;
         private int Roll_nos ;



    public string Name{

        get {

            return name ;
            
        }

        set {
             name = value ;
             

        }
    }

    public int Rolll_nos{

        get{
            return roll_nos;

        }
        set{

            roll_nos = value;
        }
    }


    }

    public class TestStudent{

        public static void Main(){


            Student S1 = new Student;

            S1.Name = "Hitesh Jha";
            S1.roll_nos = 8865;

            Console.WriteLine("The name of the Student is " + S1.Name+ "and roll nos is "+S1.roll_nos);


        }
    }
 

}

namespace logicProperties{


    public class Carinfo{

        private string namesofcar;
        private int  car_nos;


        public string Names_of_car{


            get
            {
                return namesofcar;
            }
            set{

                namesofcar = value + "Rover";
            }
        }

        public int Car_nos_{


            get{

                return  car_nos;
            }

            set{

                car_nos = value+"06"
            }
        }

        }

        public class TestCarinfo{


            public static void Main(string[]args){

                Carinfo cinfo = new carinfo();

                cinfo.namesofcar = "Range";
                cinfo.car_nos = 34;

                Console.WriteLine("The names of the car is"+cinfo.name+"and the car nos is "+cinfo.car_nos);


            }
        }

}

namespace __Properties{


    public class Student{

        private static int Counter;

        public int Counter{

            counter++;

        }

        public static int Connter{

            get {

                return Counter;
            }
        }
    }


    public class _test_Student{

        public static void Main(string[]args){


            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            Console.WriteLine("The count of the Student is "+Student.Counter);

        }
    }
}


//C# Inheritance :-->

namespace Resume{


    public Class Perosnalinfo{


        public string Full_Name;
        public int Age;
        public string Gender;
        public string Marital_Status;

        public int How_many_yrs_of_experience;
        public string in_which_field;




        public void Show_personal_info(){

            Console.WriteLine("Enter your Full_name");
            Full_Name = Console.ReadLine();

            Console.WriteLine("Enter Your Age");
            Age = Console.Int32.ReadLine();

            Console.WriteLine("Enter your Gender");
            Gender = Console.Read();

            Console.WriteLine("Enter Your Marital Status");
            Marital_Status = Console.ReadLine();



        }

    }

    public class Experience :Show_personal_info{

        public void _experience(){

            Console.WriteLine("Tell me How many years of Expareinece you have?");
            How_many_yrs_of_experience = Console.ReadLine();





        }

        public string Hobbies;
        public string fav_sports;
        public string fav_things_to_do;

        public void show_other_things(){


            Console.WriteLine("What are Your Hobbbies");
            Hobbies = Console.ReadLine();

            Console.WriteLine("What's the name of your fav sports");
            fav_sports = Console.Read();



            console.WriteLine("What are the fav things to do ");
            fav_things_to_do = Console.ReadLine();







        }





    }

    public class TestResume{

        public static void Main(string[]args){

              Experience E1 = new Experience();
              Experience E2 = new Experience();

              E1.Show_personal_info();
              E1.show_other_things();


              E2.Show_personal_info();
              E2.show_other_things();

              


        }
    }

}

namespace std {

    public class Address{


        public string addressline , city ,state;
        public Adress(string addressline , string city , string state){

            this.adressline = addressline;
            this.city = city;
            this.state = state;

        }
    }

    public class Employee{

        public int id;
        public string name;
        public int ph_nos;
        public Address address; //HAS-A relationship;


        public Employee(int id , string name , int ph_nos ,string Address address){

            this.id=id ;
            this.name = name ;
            this.ph_nos = ph_nos;
            this.address = address;


        }

        public void Displayaggregation(){

            console.WriteLine("The Id of the Employee is "+id+" city is "+city+" state :- "+state+
                "name of the Employee is"+name+"address is :" +address.addressline)

        }

    }

    public class TestAggregation{

        public static void Main(string[]args){

            Address A1 = new Address("Colony nos -4" , "Pune" , "Maharashtra");
            Employee E1 = new Employee(8865 ,"Hitesh Jha" , "8446049402" , "Colony nos - 4 Pune city");



            A1.Displayaggregation();
            E1.Displayaggregation();




        }
    }

}


//Ovreloading:--->

namespace Overloading{


    public class Calculate{

        public static int Add(int a  , int b ){

            return a+b ;



        
        public static float Add(int a , int b  , int c){

            return a +b + c;

        }
        public static int Multiply(int a  , int b){
            return a*b;

        }
        public static float Multiply(int a , int b , int c){

            return a*b*c;

        }
        public static int Division(int a  , int b){

            return a/b;

        }
        public static float Division(int a , int b , int c ){

            return a/b+c;

        }
        public static int Subtraction(int a , int b ){

            return a-b;
        }
        public static float Subtraction(int a  , int b , int c){

            rerturn a+b-c;
        }


    }

    public class TestOverloading{

        public static void Main(string[] args){

            Console.WriteLine("The Addition is "+ Calculate.Add(5,6,4));
            Console.WriteLine("Multiplication is"+Calculate.Multiply(4,5,6));
            Console.WriteLine("The Division  is "+Calculate.Division(4,5,55));
            Console.WriteLine("The Subtraction  is "+Calculate.Subtraction(45,52,1025));


        }

    }

}
//Overriding:-->


namespace Overriding{

    public class Teachers{

        public virtual void Learning(){

            Console.WriteLine("Teacher is taking the classes");

        } 

    }

    public class Students : Teachers{

        public override void Learning(){
            Console.WriteLine("Students learning in the class");
        }
    }
    public class TestOverriding{

        public static void Main(string[]args){

            Students S1 = new Students();
            S1.Learning();


        }
    }
}

//Base Keyword:-->

namespace BaseKeyword{

    public class HumanBeing{

        public string Color = "white";
        public string color2 = "Black";


    }
    public class Male:HumanBeing{

        public void ShowColor(){

            Console.WriteLine("The Color of the Male is "+base.color);
        }

    }
    public class Female:HumanBeing{
        public void ShowColor2(){

            Console.WriteLine("The Color of the Female is "+
                base.color2);

        }
    }

    public class TestBase{

        public static void Main(string[]args){

            HumanBeing Hb = new HumanBeing();
            Male M = new Male();
            Female Fe = new Female();

            M.ShowColor();
            Fe.ShowColor2();
            
        }
    }
}


namespace std{


    public class Animal{

        public Animal(){

            public string name;
            Console.WriteLine("Enter the name of the animal is :");
            name = Console.ReadLine();




        }

    }
    public class Lion : Animal{

        Console.WriteLine(base.Animal())


        public void ShowDisplay(){

            Console.WriteLine("Here u can use the base class")
        }
    }

    public class  TestBase{

        public static void Main(string[]args){

            Lion li = new Lion();
            li.ShowDisplay();




        }
    }
}
//Polymorphism :---->

namespace Polymorphism{


    public class Shapes(){

        public virtual void draw(){

            Console.WriteLine("This is base class ");

        }

    }
    public class Rectangle : Shapes{

        public override void draw(){

            Console.WriteLine("The Rectnagle is drawn from base class ");

        }

    }

    public class Square : shapes{

        public override void drtaw(){

            Console.WriteLine("Here Runtime Plomorphism is used ");

        }
    }

    public class TestPolymorphism{

        public static void Main(string[]args){

            Shapes s ;
            s = new Shapes();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Square();
            s.draw();



        }
    }
}

namespace std{

    public class shapes{

        public string color = "Orange";

    }
    public class Circle:shapes{

        public string color = "Black";

    }
    public class TestPolymorphsim{

        public static void Main(string[]args){

            shapes s = new shapes();
            s.color;

        }
    }

}

//Sealed:-->
namespace Sealed{

    public class Cars{

        public virtual Car_name(){

            Console.WriteLine("The name of the car is : Range Rover");

        }
        public virtual Car_mileage(){

            Console.WriteLine("The mileage of the car is :25km" );

        }
        sealed public virtual car_nos(){

            Console.WriteLine("The nos on the car is : 8865");

        }
    }
    public class MiniCar : Cars{

        public override car_name{

            console.WriteLine(" the name of the car is Mini Cuper");
        }
        public override car_mileage(){

            Console.WriteLine("The mileage  of the car is 30km ");

        }
        public override Car_nos(){
            Console.WriteLine("The nos of the car is : 0304");
        }
    }

    public class TestSealed{

        public static void Main(string[]args){

            Cars car = new Cars();
            car.car_name();
            MiniCar m_c = new MiniCar();
            m_c.car_name();
            car.car_mileage();
            m_c.car_mileage();
            car.car_nos();
            m_c.car_nos();
        
        }
    }
}

//Abstract class:-->
namespace Abstractclass{

    public abstract class Shape{

        public abstract void Draw();
    }
    public class Rectangle : Shape{

        public override void Draw(){

            Console.WriteLine("I'm drawing Rectangle");
        }
    }
    public class Circle:Shape{

        public override void Draw(){

            Console.WriteLine("I'm drawing now Circle");

        }
    }
    public class Square : Shape{

        public override void Draw(){
            Console.WriteLine("I'm drawing Square now");

        }
    }
    public class TestAbstract{
        public static void Main(string[]args){

            Shape S;
            S = new Rectangle();
            S.Draw();
            S = new Circle();
            S.Draw();
            S = new Square();
            S.Draw();



        }
    }
}
namespace First{

    public class Hello{

        Console.WriteLine("Hello");
    }
}
namespace Second{

    public class World{

        Console.WriteLine("World")
    }

    public  void __Show_info__(){

        Console.WriteLine(First.Hello Second.World);
    }
}
namespace TestNamespace{

    public static void Main(string[]args){

        First.Hello fh = new First.Hello();
        Second.World sw = new Second.World();

        fh.__Show_info__();
        sw.__Show_info__();




    }
}

namespace Access_Specifier{


    class Protected_class{

        protected int Emp_id = 8865;
        protected void Msg(string name){

            Console.WriteLine("Hello"+Msg);
        }


    }

    class Details:Protected_class{

        protected string Address_City = "Pune City";

        protected void Show_msg(string name){

            Console.WriteLine("Hello"+Show_msg);
        }

    }


}
namespace Protected_Access_Specifier{

    public static void Main(string[]args){

        Details D1 = new Details();
        Details D2 = new Details();

        D1.Protected_Access_Specifier.Msg();
        D2.Protected_Access_Specifier.Show_msg();


    }
}

namespace Access_Specifier__{

    class Shapes{


        internal string name_of_shape = "Rectangele";
        internal void __show__(string color){

            Console.WriteLine("The Shape is "+__show__);

        }
    }

    class Shapes{

        static void Main(string[]args){

            Shapes sh = new Shapes();
            sh.__show__("Black");



        }


    }
}

namespace Encapsulation{

    public class Student{

        public int Student_id = {get;set;};
        public string Student_name = {get;set;};
        public string Address_city = {get;set;};

        public void __Display__(){

            Console.WriteLine("Student ID is : "+Student_id);
            Console.WriteLine("Student name is :"+Student_name);
            console.WriteLine("Student Adress City is :"Address_City);

        }

    }

    public class TestStudent:Student{

        public static void Main(string[]args){

            Student S1 = new Student();
            Student S2 = new Student();

            S1.__Display__();
            S2.__Display__();

            


        }
    }
}
