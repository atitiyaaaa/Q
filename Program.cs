class Program{
    
    public static void Main (string[] args) {

        double[]values = new double[1000];
        int count = 0;
        double sum = 0;

        while (true){
            string input = Console.ReadLine();
            if (input == "End"){
                break;
            }
        double value = double.Parse(input);
        count++;
        sum += value;
        }
        
        string mode = Console.ReadLine();

        switch (mode){
            case "FindMax";
            double max = double.MinValue;
            for (int i = 0;i < count; i==){
                if (values[i]>max){
                    max = values[i];
                }
            }
            Console.writeLine(min);
            bake;
            case "FindMean";
            double mean = sum / count;
            Console.WriteLine(mean);
            break;

        default;
        Console.WriteLine("Invalid mode");
        break;
        
        }
    }
}