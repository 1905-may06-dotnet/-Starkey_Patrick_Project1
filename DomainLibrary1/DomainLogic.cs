using System;
namespace DomainLibrary1
{
    public class PizzaOrder
    {
        //need to add date compare to here
        public string AddTopping(int c)

        {
            switch (c)
            {
                case 1:

                    return "ham";

                case 2:

                    return "Pinapple";



                case 3:

                    return "Peperoni";



                case 4:

                    return "Bacon";



                case 5:

                    return "Mushroom";



                case 6:

                    return "anchovies";



                case 7:

                    return "";



            }
            return "";
        }

        public Pizzahistory pizzaAdd<S, C, T>(string id, S size, C crust, string Topping1, string Topping2, string Topping3, string Topping4, string Topping5, int storId)

        {

            // var newT = top.ToArray();



            Pizzahistory temp = new Pizzahistory();//id, size.ToString(), crust.ToString(), topping1, topping2, topping3, topping4, topping5, storId);
            temp.UserId = id;
            temp.Size = size.ToString();
            temp.Crust = crust.ToString();
            temp.Topping1=Topping1;
            temp.Topping2= Topping2;
            temp.Topping3= Topping3;
            temp.Topping4= Topping4;
            temp.Topping5 = Topping5;
            temp.StoreId=storId;


            return temp;

        }
        public decimal Cost(string size, int toppingsTotal)

        {



            int sizeCost = 5;

            if (size == "medium")

            {

                sizeCost = 7;

                return (sizeCost + (toppingsTotal) * .75m);



            }

            else if (size == "large")

            {

                sizeCost = 10;

                return (sizeCost + (toppingsTotal) * 1.75m);



            }

            else

            {



                return (sizeCost + (toppingsTotal) * .25m);

            }



        }
        
        public Boolean canTheyLogIn(int storeId,int orderFromID,DateTime LastpizzaTime)
        {
            DateTime current = DateTime.Now;
            if (DateTime.Compare(current.AddHours(-2),LastpizzaTime ) < 0)
            {

                if (storeId == orderFromID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else if(DateTime.Compare(current.AddHours(-24), LastpizzaTime) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public Boolean Logging(string user,string password,string aUser, string aPassword)
        {
            if (user != aUser)
            {
                return false;
            }
            else
            {
                if (password == aPassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


        //void Createorder()

        //{

        //    String temp;

        //    Boolean thenend = false;

        //    decimal totalPrice = 0;

        //    int orderlimit = 5000;

        //    int pizzaTotal = 0;

        //    do

        //    {

        //        pizzaTotal = pizzaTotal + 1;

        //        //totalPrice = totalPrice + buildPizza();

        //        if (totalPrice >= orderlimit || pizzaTotal >= 100)

        //        {

        //            Console.WriteLine("your order is too large or too expensive.");

        //            break;

        //        }

        //        Console.WriteLine("Do wish to add more?y/n");

        //        temp = Console.ReadLine();

        //        if (temp == "n")

        //        {



        //            thenend = true;

        //        }





        //        else

        //        {



        //        }

        //    } while (thenend == false);









        //}





    }
}
