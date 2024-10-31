namespace UT2024P4LP4.Web.Data.Dtos;

public class CategoriaDto (int id = 0, string? nombre = null)
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;

    public CategoriaRequest ToRequest()
    => new()
    {
        Id = this.Id,
        Nombre = this.Nombre,
    };
}

public class CategoriaRequest
{
    public int Id { get; set; } = 0;
    public string Nombre { get; set; } = "";
}