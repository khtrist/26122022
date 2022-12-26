using System;
using test_26122022;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string option;


            do

            {


                Console.WriteLine("1. User Elave et");
                Console.WriteLine("2. Userlere Bax");
                Console.WriteLine("3. Userler uzre axtaris");
                Console.WriteLine("0. Menyudan Cix");
                User[] users = new User[0];
                option = Console.ReadLine();

                if (option == "1")
                {
                    User[] newUsers = new User[users.Length + 1];

                    for (int i = 0; i < users.Length; i++)
                    {
                        newUsers[i] = users[i];
                    }



                    try
                    {

                        var user = CreateUser();
                        Array.Resize(ref users, users.Length + 1);
                        users[^1] = user;
                    }


                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR 404");
                        Console.WriteLine("Xeta: " + e.Message);
                    }
                }

                else if (option == "2")
                {
                    Console.WriteLine("Userlere bax");
                    string search = Console.ReadLine();

                    var filteredArr = SearchUser(users, search);

                    ShowInfo(filteredArr);
                    Console.WriteLine(users.Length);
                   
                }

                else if (option == "3")
                {
                    Console.WriteLine("Userler uzre Search:");
                    string search = Console.ReadLine();

                    var filteredArr = SearchUser(users, search);
                    ShowInfo(filteredArr);  
                    Console.WriteLine(users.Length);



                }
            } while (option != "0");

        }



        static User[] SearchUser(User[] arr, string search)
        {
            User[] newArr = new User[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ShowUserInfo(search))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }

            return newArr;
        }

        static void ShowInfo(User[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ShowUserInfo(Date()));
            }
        }



        public static string Date()
        {
            string date = "26/12/2022";

            DateTime dateTime;
            if (DateTime.TryParse(date, out dateTime))
            {
                Console.WriteLine("The specified date is valid: " + dateTime);
            }
            else
            {
                Console.WriteLine("Göstərilən tarixi təhlil etmək mümkün deyil");
            }
            return date;
        }


        static User CreateUser()
        {
            do
            {

            
                    User user = new User();
                
                    Console.WriteLine("User yarat:" + Date());
                    Console.WriteLine("Username:");
                    string username = Console.ReadLine();

                    bool check = true;
                    if (string.IsNullOrWhiteSpace(username) && username.Length >= 6 && username.Length <= 25)

                    {
                        throw new UserNameFormatException("Username minimum 6 maksimum 25 simvoldan ibaret olmalidir!");
                    }

               


                
                    Console.WriteLine("Password Yazin: ");
                    string passwordStr = Console.ReadLine();
                    string password = Convert.ToString(passwordStr);

                    if (string.IsNullOrWhiteSpace(password) && password.Length >= 8 && password.Length <= 25)


                    {
                        throw new UserNameFormatException("Password minimum 8 maksimum 25 simvoldan ibaret olmalidir!");
                    }


                

            } while (true);
            

            

        }

        
    }
}
