using System;
using System.ComponentModel.DataAnnotations;

public class Qr
{
    [Key]
    public string id { get; set; }
    public string Modelo { get; set; }

	public int propietario { get; set; }

	public string Descripcion { get; set; }


}
