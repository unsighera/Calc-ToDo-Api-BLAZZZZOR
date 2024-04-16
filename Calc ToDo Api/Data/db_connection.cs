namespace Calc_ToDo_Api.Data
{
    public class db_connection
    {
        public List<Agent> agents = new List<Agent>()
        {
            new Agent("Ivanov Ivan"),
            new Agent("Petrov Petr"),
            new Agent("Sidorov Sergay")
        };

        public List<SumAgent> sumagents = new List<SumAgent>()
        {
            new SumAgent("Ivanov Ivan", 1000),
            new SumAgent("Petrov Petr", -1000),
            new SumAgent("Sidorov Sergay", 12)
        };
    }

    public class SumAgent
    {
        public string Name { get; set; }
        public int Sum { get; set; }

        public SumAgent(string name, int sum)
        {
            Name = name;
            Sum = sum;
        }
    }
    public class Agent
    {
        public Agent(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
