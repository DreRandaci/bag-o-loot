namespace bagOLoot
{
    public class Present
    {
        public string Name { get; set; }
        public Child Child { get; set; }
        public bool Delivered { get; set; } = false;

        public Present(Child child)
        {
            Child = child;
        }
    }
}