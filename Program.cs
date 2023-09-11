internal class Program
{
    private static void Main(string[] args)
    {
        string[] myShoppingList = new string[2];
        myShoppingList[0] = "ChimenyCake";
        myShoppingList[1] = "Ice Cream";

        Console.WriteLine(myShoppingList[0]);
        Console.WriteLine(myShoppingList[1]);
        Console.WriteLine("Inna lista:");  //Array is static with already provided values

        string[] mySecondList = { "Ham", "Cheese", "Apples" };

        Console.WriteLine(mySecondList[0]);
        Console.WriteLine(mySecondList[1]);
        Console.WriteLine(mySecondList[2]);

        List<string> myList = new List<string>() {"Item no 1", "Item no 2"};
        
        myList.Add("Item no 3");
        myList.Add("Item no 69");
        //List is dynamic and values can be added anytime
        Console.WriteLine("List's elements: " + myList[0] +", " + myList[1] + ", " + myList[3]);

        /*IEnumerable<string> myIeLIST = myList;
        Console.WriteLine(myIeLIST.First()); //Ienumerable lets us search through the list */

        string[,] my2Darray = new string[,]  //Two dimensional array(array of arrays)
        {
            {"Lion", "Tiger", "Puma"},
            {"Dog", "Cat", "Hamster"},
            {"Bobby", "Milly", "Wacky"},
        };
        Console.WriteLine("1st element of 3rd array of 2D array: " + my2Darray[2, 0]); //Highlights 1st element of 1st array
        Console.WriteLine("2nd element of 2nd array of 2D array: " + my2Darray[1, 1]); //Highlights 1st element of 2nd array

        Dictionary<string, string> myDictionaryList = new Dictionary<string, string>()
        {
            {"Cheese", "Diary"}
        };
        Console.WriteLine("Provided key 'Cheese' = " + myDictionaryList["Cheese"]); //You can use double, decimal, int etc. instead of string
    
    }
}

