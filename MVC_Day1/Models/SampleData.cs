using System.Numerics;

namespace MVC_Day1.Models
{
    public static class SampleData
    {
        private static List<People> peoples = new List<People>()
        {
            new People()
            {
            Name= "Ali",
            Email= "Ali@gmail.com",
            Phone="0123456755",
            WillAttend=true
            },
            new People()
            {
            Name= "Ahmed",
            Email= "Ahmed@gmail.com",
            Phone="0123456985",
            WillAttend=false
            }
        };
        public static List<People> Peoples { get => peoples; }
        public static void AddPeople(People people)
        {
            peoples.Add(people);
        }
    }
}

