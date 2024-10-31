namespace GetConselho_Api.Model;

public class ConselhoResponse
{
    public Slip Slip { get; set; }
}

public class Slip
{
    public int Id { get; set; }
    public string Advice { get; set; }
}
