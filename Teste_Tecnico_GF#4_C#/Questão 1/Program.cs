class Program
{
    static void Main()
    {        
        int agedPeople = 0;
        double averageHeight = 0.0 , averageHeightCount = 0.0, average = 0.0, percentageWeight = 0.0;
        for (int i = 0; i < 2; i++)
        {    
            if (i == 0) Console.WriteLine("Inform the age of the 1st person");
            else if (i == 1) Console.WriteLine("Inform the age of the 2nd person");
            else if (i == 2) Console.WriteLine("Inform the age of the 3rd person");
            else Console.WriteLine($"Inform the age of the {i+1}th person");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inform his height");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("And finally inform his weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            if (age > 50) agedPeople++;
            if (age >= 10 && age<= 20) 
            {
                averageHeightCount++;
                averageHeight += height;
            }
            if (weight < 40) percentageWeight+= 0.1;
           
        }
        average = averageHeight/averageHeightCount;
        Console.WriteLine($"There are {agedPeople} people over 50 years old");
        Console.WriteLine($"The average height of people between 10 and 20 years old is {average} Centimeters");
        Console.WriteLine($"The percentage of people with less than 40 Kilograms is {100 * percentageWeight}%");
    }
}
