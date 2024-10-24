namespace kursus
{
    class Furniture // PARENT class
    {
        // skift fra private til protected når nedarves
        protected double cost;
        protected string manufacturer;

        public void SetCost(double cost)
        {
            this.cost = cost;
        }
        public double GetCost()
        {
            return cost;
        }
        public void SetMenufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }
        public string GetManufacturer()
        {
            return manufacturer;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Møbel fra " + manufacturer + " koster: " + cost + " kr");
        }
    }
    class Chair : Furniture // CHILD class
    {
        protected string model;
        public void SetModel(string model)
        {
            this.model = model;
        }
        public string GetModel()
        {
            return model;
        }
        public void PrintInfo()
        {
            Console.WriteLine(model + " fra " + manufacturer + " koster: " + cost + " kr");
        }
    }
    class ChairAndDimensions : Chair // CHILD til chair (yderligere subklasse)
    {
        protected double height;
        protected double width;
        protected double length;
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetLength(double length)
        {
            this.length = length;
        }
        public double GetLength()
        {
            return length;
        }
        public void PrintInfo()
        {
            Console.WriteLine(model + " fra " + manufacturer + " koster: " + cost + " kr");
            Console.WriteLine(model + " dimensioner: højde = " + height + " cm | bedde = " + width + " cm | længde = " + length + " cm");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChairAndDimensions thing = new ChairAndDimensions();
            thing.SetMenufacturer("IKEA");
            thing.SetCost(499.95);
            thing.SetModel("ÖSTANÖ stol");
            
            thing.SetHeight(110.5);
            thing.SetWidth(64);
            thing.SetLength(69);

            thing.PrintInfo();
        }
    }
}
