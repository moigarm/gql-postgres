namespace API
{
    public class SubEntidad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SubSubEntidad[] SubSubEntidades { get; set; }
    }
}
