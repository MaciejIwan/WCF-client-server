namespace Dto
{
    public struct Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}";
        }
    }
}