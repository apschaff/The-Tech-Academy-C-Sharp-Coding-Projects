namespace _162ExerciseFeatures
{
    class Person
    {
        //Chain two constructors together
        public Person(string name) : this(name, 0)
        {
        }
        public Person(string name, int age)
        {
            int personAge = age;
            string personName = name;
        }
    }
}
