using System;

namespace Task_2
{
    struct Train
    {
        public string point_of_direction;
        public int number_of_train;
        public string departure_time;     

    }

    class Program
    {
        static void ShowTrainsByNumber(Train[] trains, int number)
        {
            bool train_exist = false;
            for (int i = 0; i < trains.Length; i++)
            {
                if (number == trains[i].number_of_train)
                {
                    Console.WriteLine($"Point of direction: {trains[i].point_of_direction}\nTrain number: {trains[i].number_of_train}\nDeparture time: {trains[i].departure_time}\n");
                    train_exist = true;                  
                }
            }
            if (train_exist == false)
            {
                Console.WriteLine("There is no train with this number");
            }

         }
            static void Trains(Train[] trains)
        {
            int train_counter = 1;
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Enter information of the " + train_counter + " train");
                Console.WriteLine("Enter point of direction");
                trains[i].point_of_direction = Console.ReadLine();
                Console.WriteLine("Enter number of train");
                trains[i].number_of_train = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter departure time");
                trains[i].departure_time = Console.ReadLine();
                train_counter++;
            }

        }
        static void Main(string[] args)
        {
            Train[] trains = new[] { new Train { point_of_direction = default, departure_time = default, number_of_train = default }, new Train { point_of_direction = default, departure_time = default, number_of_train = default } };
            Trains(trains);

            Console.WriteLine("enter the train number to see information about it");
            int number = Int32.Parse(Console.ReadLine());
            ShowTrainsByNumber(trains, number);
        }
    }
}
