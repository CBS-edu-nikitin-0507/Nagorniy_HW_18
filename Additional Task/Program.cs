using System;

namespace Additional_Task
{
    struct Notebook
    {
        public string model { get; }
        public string manufacture { get; }
        public int price { get; }

        public Notebook(string model, string manufacture, int price)
        {
            this.model = model;
            this.manufacture = manufacture;
            this.price = price;

        }
        public void Show()
        {
            Console.WriteLine($"Mode: {model}\nManufacture: {manufacture}\nPrice: {price} UAH");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("AH300", "Lenovo", 15000);
            notebook.Show();
        }
    }
}
