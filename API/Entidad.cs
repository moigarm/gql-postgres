using System.ComponentModel.DataAnnotations.Schema;

namespace API
{
    public class Entidad
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName ="jsonb")]
        public SubEntidad[] SubEntidades { get; set; }
    }
}
